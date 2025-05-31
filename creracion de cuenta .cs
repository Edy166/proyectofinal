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
    public partial class creracion_de_cuenta : Form
    {
        public int contador = 0;

        public creracion_de_cuenta()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                txtpasword.PasswordChar = '\0';
                contador = 1;
            }
            else
            {
                txtpasword.PasswordChar = '*';
                contador = 0;
            }
        }

        private void piccreacionojo2_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                txtconfirmacion.PasswordChar = '\0';
                contador = 1;
            }
            else
            {
                txtconfirmacion.PasswordChar = '*';
                contador = 0;
            }
        }

        // funcion para que cuando el usuario escriba sea de color negro 
        private void txtname_Enter(object sender, EventArgs e)
        {
            
        }
    
        // creacion de la funcion para que cuando el usuario no escriba nada el texto vuelva a su color original
        private void txtname_Leave(object sender, EventArgs e)
        {
            
        }

        private void salirregistro_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1login login = new Form1login();
            login.Name = "creracion_de_cuenta";

        }

        private void btonewuser_Click(object sender, EventArgs e)
        {
            //BLOQUE PARA QUE USUARIO CREE SU CUENTA
            string Nombre = txtname.Text.Trim();
            string usuario = tbxuser.Text.Trim();
            string contrasena = txtpasword.Text.Trim();
            string confirmar_contrasena = txtconfirmacion.Text.Trim();
            string telefono = txttelefono.Text.Trim();

           



            if(  Nombre =="" || usuario == "" || contrasena == "" || confirmar_contrasena == "" || telefono == "")
            {
                MessageBox.Show("POR FAVOR INGRESE TODOS LOS CAMPOS.");
                return;
            }

            if (contrasena != confirmar_contrasena)
            {
                MessageBox.Show("LAS CONTRASEÑAS NO SON IDÉNTICAS.");
                return;
            }

            // Dirección del servidor completa de Azure y agregar los datos del servidor, base de datos y contraseña del servidor.
            string connectionString = ("Server = tcp:proyectoprogramacion.database.windows.net,1433; Initial Catalog = proyectofinal; Persist Security Info = False; User ID = proyectofinal;Password=2025*umg;MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    // Crear la tabla si no existe.
                    string CrearTabla = "IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='usu' AND xtype='U')" +
                        "CREATE TABLE usu (ID INT IDENTITY(1,1) PRIMARY KEY, USUARIO NVARCHAR(50) NOT NULL, PASSWORD NVARCHAR(100) NOT NULL)";
                    using (SqlCommand comando = new SqlCommand(CrearTabla, conexion))
                    {
                        comando.ExecuteNonQuery();
                    }

                        //Para validar si el usuario ya existe.
                        string ValidarUsuario = "SELECT COUNT(*) FROM usuarios1 WHERE USUARIO = @usuario";
                    using (SqlCommand comando = new SqlCommand(ValidarUsuario, conexion))
                    {
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        int existe = (int)comando.ExecuteScalar();
                        if (existe > 0)
                        {
                            MessageBox.Show("USUARIO EXISTENTE, POR FAVOR ELIJA OTRO.");
                            return;
                        }
                    }

                    // Insertar el nuevo usuario en la base de datos.
                    string NewUser = "INSERT INTO usuarios1 (NOMBRE,USUARIO, PASSWORD,TELEFONO) VALUES ( @nombre,@usuario,@contrasena,@tefono)";
                    using (SqlCommand comando = new SqlCommand(NewUser, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", Nombre);
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@contrasena", contrasena);
                        comando.Parameters.AddWithValue("@tefono", telefono); 

                        int resultado = comando.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("CUENTA CREADA EXITOSAMENTE.");
                            this.Close();
                            Form1login login = new Form1login();
                            login.Name = "creracion_de_cuenta";
                        }
                        else
                        {
                            MessageBox.Show("ERROR.POR FAVOR INTENTE DE NUEVO.");
                        }
                    }
                }

                catch (Exception ex)
                {
                   MessageBox.Show("ERROR AL CONECTAR CON LA BASE DE DATOS: " + ex.Message);
                }       
            }        
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }       
    }
}
