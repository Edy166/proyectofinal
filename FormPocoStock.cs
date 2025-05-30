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
    public partial class FormPocoStock: Form
    {
        public FormPocoStock()
        {
            InitializeComponent();

            toolTip1.SetToolTip(picVolverMenu, "Volver al menú principal");

        }

        private void FormPocoStock_Load(object sender, EventArgs e)
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

            string query = "SELECT * FROM productos WHERE EXISTENCIAS < 10"; //Llama la tabla de existencias 

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewPocoStock.DataSource = dt;
                    dataGridViewPocoStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos con poco stock: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picVolverMenu_Click(object sender, EventArgs e)
        {
            this.Hide();  // Oculta el formulario actual
            Menu_Principal menu = new Menu_Principal(); // Crea el menú
            menu.Show();  // Muestra el menú principal
        }
    }
}
