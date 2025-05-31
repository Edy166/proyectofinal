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
    public partial class menu_agregar : Form
    {
        public menu_agregar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu_Principal menu = new Menu_Principal();
            menu.Name = "menu_agregar";
        }

        private void btn_agregar_productor_Click(object sender, EventArgs e)
        {
            
            string Nombre_del_producto = txt_nombre_del_producto.Text.ToLower();
            string codigo = txt_codigo_del_producto.Text.ToLower();
            string costo = txt_precio_costo.Text.ToLower();
            string venta = txt_precio_venta.Text.ToLower();
            string stock = txt_Existencias.Text.ToLower();

            
            if ( Nombre_del_producto == "" || codigo == "" || costo =="" || venta == "" || stock == "")
            {
                MessageBox.Show("POR FAVOR INGRESE TODOS LOS CAMPOS.");
                return;
            
            }

            // conexion a la base de datops 
            string connectionString = ("Server = tcp:proyectoprogramacion.database.windows.net,1433; Initial Catalog = proyectofinal; Persist Security Info = False; User ID = proyectofinal;Password=2025*umg;MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                { 
                  conexion.Open();

                    // bloque para validar producto si el producto ya existe o no
                    string validar_producto = "SELECT COUNT(*) FROM productos WHERE NOMBRE_DEL_PRODUCTO = @Nombre_del_producto";
                    using (SqlCommand comando = new SqlCommand(validar_producto, conexion))
                    {
                        comando.Parameters.AddWithValue("@NOMBRE_DEL_PRODUCTO", Nombre_del_producto);
                        int count = (int)comando.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("El producto ya existe.");
                            return;
                        }
                    }

                    string insertar_producto = "INSERT INTO productos (NOMBRE_DEL_PRODUCTO, CODIGO_DEL_PRODUCTO, PRECIO_COSTO, PRECIO_VENTA, EXISTENCIAS) " +
                           "VALUES (@NOMBRE_DEL_PRODUCTO, @CODIGO_DEL_PRODUCTO, @PRECIO_COSTO, @PRECIO_VENTA, @EXISTENCIAS)";

                    using (SqlCommand comando = new SqlCommand(insertar_producto, conexion))
                    {
                        comando.Parameters.AddWithValue("@NOMBRE_DEL_PRODUCTO", Nombre_del_producto);
                        comando.Parameters.AddWithValue("@CODIGO_DEL_PRODUCTO", codigo);
                        comando.Parameters.AddWithValue("@PRECIO_COSTO", costo);
                        comando.Parameters.AddWithValue("@PRECIO_VENTA", venta);
                        comando.Parameters.AddWithValue("@EXISTENCIAS", stock);

                        int resultados = comando.ExecuteNonQuery();

                        if (resultados > 0)
                        {
                            MessageBox.Show("PRODUCTO AGREGADO CON EXITO.");
                            this.Close();
                             Menu_Principal menu = new Menu_Principal();
                            menu.Name = "Menu_principal";
                        }
                        else
                        {
                            MessageBox.Show("ERROR. POR FAVOR INTENTE DE NUEVO.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL CONECTAR CON LA BASE DE DATOS: " + ex.Message);


                }
            }

        }
    }
}
