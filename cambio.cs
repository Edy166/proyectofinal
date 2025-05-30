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
   
  
    public partial class cambio_de_contrasena : Form
    {
        // una variable global para ver la contra 
        public int ver = 0;

        public string UsuarioRecuperado { get; set; }
        public cambio_de_contrasena()
        {
            InitializeComponent();
        }

        private void btonewuser_Click(object sender, EventArgs e)
        {
            string nuevaContrasena = txtnewpassword.Text.Trim();
            string confirmarContrasena = txtconfirmacion.Text.Trim();

            if (string.IsNullOrEmpty(nuevaContrasena) || string.IsNullOrEmpty(confirmarContrasena))
            {
                MessageBox.Show("Por favor, ingrese ambas contraseñas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nuevaContrasena != confirmarContrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Server=tcp:proyectoprogramacion.database.windows.net,1433;Initial Catalog=proyectofinal;Persist Security Info=False;User ID=proyectofinal;Password=2025*umg;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "UPDATE usuarios1 SET PASSWORD = @contrasena WHERE USUARIO = @usuario";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@contrasena", nuevaContrasena);
                    cmd.Parameters.AddWithValue("@usuario", UsuarioRecuperado);  // viene del formulario anterior

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Contraseña actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        Form1login loginForm = new Form1login();
                        loginForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la contraseña. Verifique el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la contraseña: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picojonuevacontra_Click(object sender, EventArgs e)
        {
            if (ver == 0)
            {
                txtnewpassword.PasswordChar = '\0';
                ver = 1;
            }
            else
            {
                txtnewpassword.PasswordChar = '*';
                ver = 0;
            }
        }

       

        private void piccreacionojo2_Click(object sender, EventArgs e)
        {
            if (ver == 0)
            {
                txtconfirmacion.PasswordChar = '\0';
                ver = 1;
            }
            else
            {
                txtconfirmacion.PasswordChar = '*';
                ver = 0;
            }
        }  
    }
}
