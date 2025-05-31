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
    public partial class Form1login : Form
    {
        public int contador = 0;

        public Form1login()
        {
            InitializeComponent();
        }

        private void label2derecuperacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            contrasena_olvidada contrasenaOlvidada = new contrasena_olvidada();
            contrasenaOlvidada.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                txtcontraseña.PasswordChar = '\0';
                contador = 1;
            }
            else
            {
                txtcontraseña.PasswordChar = '*';
                contador = 0;
            }
        }

        public void LimpiarCampos()
        {
            textBoxusuario.Clear();
            txtcontraseña.Clear();
            contador = 0;
            txtcontraseña.PasswordChar = '*';
        }



        private void textBoxusuario_Enter(object sender, EventArgs e)
        {
                
        }

        private void textBoxusuario_Leave(object sender, EventArgs e)
        {
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            creracion_de_cuenta crearcuenta = new creracion_de_cuenta();
            crearcuenta.ShowDialog ();
            this.Show();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string usuario = textBoxusuario.Text;
            string contraseña = txtcontraseña.Text;

            //  direccion del servidor completa de azure y agregar los datos del servidor, base de datos y password del servidor
            string connectionString = ("Server = tcp:proyectoprogramacion.database.windows.net,1433; Initial Catalog = proyectofinal; Persist Security Info = False; User ID = proyectofinal;Password=2025*umg;MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");


            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string consulta = "SELECT COUNT(*) FROM usuarios1 WHERE USUARIO = @usuario AND PASSWORD = @contraseña";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@contraseña", contraseña);

                        int resultado = (int)comando.ExecuteScalar();

                        if (resultado > 0)
                        {
                            this.Hide();
                            Menu_Principal menu = new Menu_Principal();
                            menu.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    //prueba xd 
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
    }

      
    }
}
    
