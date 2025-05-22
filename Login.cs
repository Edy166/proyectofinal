using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_2._1
{
    public partial class Form1login : Form
    {
        public int contador = 0;
        private object formRecuperar;

        public RecuperacionDeContraseña RecuperacionDeContraseña { get; private set; }

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


        //creacion del ojo para ver contraseña
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

        // funcion para que cuando el usuario escriba sea de color negro 
        private void textBoxusuario_Enter(object sender, EventArgs e)
        {
            if (textBoxusuario.Text == "Ingrese su usuario")
            { 
              textBoxusuario.Text = "";
              textBoxusuario.ForeColor = Color.Black;

            }

        }

        // funcion  para que aparezca un mensaje en el textbox de color gris
        private void textBoxusuario_Leave(object sender, EventArgs e)
        {
            if (textBoxusuario.Text == "")
            {
                textBoxusuario.Text = "Ingrese su usuario";
                textBoxusuario.ForeColor = Color.Gray;
            }
        }

        // evento para crear usuario
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            creracion_de_cuenta crearcuenta = new creracion_de_cuenta();
            crearcuenta.ShowDialog();
            this.Show();
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {

        }
    }
}
