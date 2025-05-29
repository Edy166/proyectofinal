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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void bt_Agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_agregar agregar = new menu_agregar();
            agregar.ShowDialog();
            this.Show();
        }
    }
}
