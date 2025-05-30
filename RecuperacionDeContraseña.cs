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
using System.Xml.Linq;

namespace proyecto_final_2._1
{
    public partial class contrasena_olvidada : Form
    {


      

        public contrasena_olvidada()
        {
            InitializeComponent();
        }

        private void salirregistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            creracion_de_cuenta volver = new creracion_de_cuenta();
            volver.Name = "creracion_de_cuenta";
        }

        private void btonusuariovalidar_Click(object sender, EventArgs e)
        {
            string usuario = tbxuser.Text.Trim();
            string telefono = txttelefono.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Por favor, complete ambos campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=tcp:proyectoprogramacion.database.windows.net,1433;Initial Catalog=proyectofinal;Persist Security Info=False;User ID=proyectofinal;Password=2025*umg;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "SELECT COUNT(*) FROM usuarios1 WHERE USUARIO = @usuario AND TELEFONO = @telefono";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@telefono", telefono);

                try
                {
                    conn.Open();
                    int resultado = (int)cmd.ExecuteScalar();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Identidad confirmada. Puede continuar con la recuperación.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();  // Oculta el formulario actual

                        cambio_de_contrasena cambio = new cambio_de_contrasena();
                        cambio.UsuarioRecuperado = tbxuser.Text.Trim();  
                        cambio.ShowDialog();  // Muestra el nuevo formulario

                        this.Close();  // Cierra el formulario actual después de completar

                    }
                    else
                    {
                        MessageBox.Show("Usuario o teléfono incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
