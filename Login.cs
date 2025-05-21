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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //EDINSON BAUTISTA
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        /*PRUEBA DE CAMBIO*/

        private void label1usuario_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxusuario_Enter(object sender, EventArgs e)
        {
         
        }

        private void Z(object sender, EventArgs e)
        {

        }

        private void Form1login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textcontraseña_TextChanged(object sender, EventArgs e)
        {

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
    }
}
