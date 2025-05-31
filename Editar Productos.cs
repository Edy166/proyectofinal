using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace proyecto_final_2._1
{
    public partial class Editar_Productos : Form
    {
        public Editar_Productos()
        {
            InitializeComponent();
        }

        //<<< Conectar a la BD>>>//
        string connectionString = ("Server = tcp:proyectoprogramacion.database.windows.net,1433; Initial Catalog = proyectofinal; Persist Security Info = False; User ID = proyectofinal;Password=2025*umg;MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Editar_Productos menu = new Editar_Productos();
            menu.Name = "Editar_productos";
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            //<<< Obtener datos de los campos >>>//
            string id = txtbuscarid.Text.Trim();
            string nombre = txtnombreprod.Text.Trim();
            string codigo = txtcodprod.Text.Trim();
            string costoStr = txtpreciocosto.Text.Trim();
            string ventaStr = txtprecioventa.Text.Trim();
            string stockStr = txtexistencias.Text.Trim();

            //<<< Validar que todos los campos estén llenos >>> //
            if (nombre == "" || codigo == "" || costoStr == "" || ventaStr == "" || stockStr == "")
            {
                MessageBox.Show("POR FAVOR INGRESE TODOS LOS CAMPOS.");
                return;
            }

            //<<< Validar que los campos numéricos tengan valores correctos >>>//
            if (!decimal.TryParse(costoStr, out decimal costo) ||
                !decimal.TryParse(ventaStr, out decimal venta) ||
                !int.TryParse(stockStr, out int stock))
            {
                MessageBox.Show("POR FAVOR INGRESE VALORES NUMÉRICOS CORRECTOS EN COSTO, VENTA Y STOCK.");
                return;
            }

            //<<< Validar la tabla de productos >>>//
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string updateSQL = @"UPDATE productos SET 
                                 CODIGO_DEL_PRODUCTO = @Codigo,
                                 PRECIO_COSTO = @Costo,
                                 PRECIO_VENTA = @Venta,
                                 EXISTENCIAS = @Stock
                                 WHERE NOMBRE_DEL_PRODUCTO = @Nombre";

                    using (SqlCommand cmd = new SqlCommand(updateSQL, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Codigo", codigo);
                        cmd.Parameters.AddWithValue("@Costo", costo);
                        cmd.Parameters.AddWithValue("@Venta", venta);
                        cmd.Parameters.AddWithValue("@Stock", stock);

                        int filas = cmd.ExecuteNonQuery();
                        if (filas > 0)
                        {
                            MessageBox.Show("Producto actualizado correctamente.");

                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto para actualizar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL CONECTAR O ACTUALIZAR: " + ex.Message);
                }
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string id = txtbuscarid.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Por favor, ingrese un ID.");
                return;
            }

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM productos WHERE ID = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dvgproductos.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("NO SE ENCONTRÓ EL PRODUCTO.");
                            return;
                        }

                        // <<< Rellenar los campos con los valores del producto >>> //
                        DataRow fila = dt.Rows[0];

                        txtnombreprod.Text = fila["NOMBRE_DEL_PRODUCTO"].ToString();
                        txtcodprod.Text = fila["CODIGO_DEL_PRODUCTO"].ToString();
                        txtpreciocosto.Text = fila["PRECIO_COSTO"].ToString();
                        txtprecioventa.Text = fila["PRECIO_VENTA"].ToString();
                        txtexistencias.Text = fila["EXISTENCIAS"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR DE BÚSQUEDA: " + ex.Message);
                }
            }
        }
    }
}