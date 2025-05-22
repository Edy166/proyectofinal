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
            if (txtname.Text == "Nombre completo")
            {
                txtname.Text = "";
                txtname.ForeColor = Color.Black;
            }
        }

        // creacion de la funcion para que cuando el usuario no escriba nada el texto vuelva a su color original
        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            { 
              txtname.Text = "Nombre completo";
              txtname.ForeColor = Color.Black;
            }
        }

        private void salirregistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            creracion_de_cuenta cerrar = new creracion_de_cuenta();
            cerrar.Name = txtname.Text;
        }

        private void btonewuser_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Usuario creado con exito");

            Form1login loginForm = new Form1login();
            this.Close();
            loginForm.Show();
           
        }
    }
}
