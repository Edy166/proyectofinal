

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proyecto_final_2._1
{
    public partial class tabla_de_eliminar_productos4 : Form
    {
        private string connectionString = "Server=tcp:proyectoprogramacion.database.windows.net,1433;Initial Catalog=proyectofinal;Persist Security Info=False;User ID=proyectofinal;Password=2025*umg;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection Conex;
        private SqlDataAdapter adapt;
        public tabla_de_eliminar_productos4()
        {
            InitializeComponent();
            ObtenerRegistro();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
           
        }
        private void ObtenerRegistro()
        {
            try
            {
                using (Conex = new SqlConnection(connectionString))
                {
                    Conex.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("SELECT * FROM productos", Conex);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los registros: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int idProducto = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                    try
                    {
                        using (Conex = new SqlConnection(connectionString))
                        {
                            Conex.Open();
                            string query = "DELETE FROM productos WHERE ID = @ID";
                            SqlCommand cmd = new SqlCommand(query, Conex);
                            cmd.Parameters.AddWithValue("@ID", idProducto);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Producto eliminado correctamente.");
                        ObtenerRegistro(); // Refrescar la tabla
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un producto para eliminar.");
            }
        }
    }

}

    
