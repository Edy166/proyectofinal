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
            this.Hide();  

            cambio_de_contrasena cambio = new cambio_de_contrasena();
            cambio.ShowDialog();  

    
            this.Close();
        }
    }
}
