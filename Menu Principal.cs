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
        private object textBoxusuario;

        public Menu_Principal()
        {
            InitializeComponent();
            
            panel_menu_principal.Visible = false; // OCULTAR EL PANEL DEL MENU PRINCIPAL AL INICIAR
            panel_cerrar_sesion.Visible = false; // OCULTAR EL PANEL DE CERRAR SESION AL INICIAR
        }

        private void bt_Agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_agregar agregar = new menu_agregar();
            agregar.ShowDialog();
            this.Show();
        }

       

        private void pic_configuracion_Click(object sender, EventArgs e)
        {
            panel_menu_principal.Visible = true; 
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
             panel_menu_principal.Visible = !panel_menu_principal.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_cerrar_sesion.Visible = !panel_cerrar_sesion.Visible; // MOSTRAR EL PANEL DE CERRAR SESION
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_cerrar_sesion.Visible = !panel_cerrar_sesion.Visible; //mostrar u ocultar el panel de cerrar sesion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1login regresar = new Form1login();
            regresar.ShowDialog();
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editar_Productos editar = new Editar_Productos();
            editar.ShowDialog();
            this.Show();
        }

        private void bt_poco_stock_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPocoStock pocoStockForm = new FormPocoStock();
            pocoStockForm.ShowDialog();
            this.Show();
        }


        private void bt_ver_producto_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormVerProductos verProductosForm = new FormVerProductos();
            verProductosForm.ShowDialog();
            this.Show();
        }
    }
}
