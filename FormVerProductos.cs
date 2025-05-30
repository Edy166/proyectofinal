using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_2._1
{
    public partial class FormVerProductos: Form
    {
        public FormVerProductos()
        {
            InitializeComponent();

            toolTip1.SetToolTip(picVolverMenu, "Volver al menú principal");
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormVerProductos_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:proyectoprogramacion.database.windows.net,1433;" +
                              "Initial Catalog=proyectofinal;" +
                              "Persist Security Info=False;" +
                              "User ID=proyectofinal;" +
                              "Password=2025*umg;" +
                              "MultipleActiveResultSets=False;" +
                              "Encrypt=True;" +
                              "TrustServerCertificate=False;" +
                              "Connection Timeout=30;";

            string query = "SELECT * FROM productos";  // Asegúrate que 'productos' es el nombre correcto

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewProductos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picVolverMenu_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta este formulario
            Menu_Principal menu = new Menu_Principal();
            menu.Show();  // Muestra el menú principal
        }
    }
}
