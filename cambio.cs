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
    }
}
