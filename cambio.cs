using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public cambio_de_contrasena()
        {
            InitializeComponent();
        }

        private void btonewuser_Click(object sender, EventArgs e)
        {
            this.Hide();  
            Form1login loginForm = new Form1login();
            loginForm.Close();    
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
