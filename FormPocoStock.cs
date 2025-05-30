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

            string query = "SELECT * FROM productos WHERE EXISTENCIAS < 10"; // ajusta si se llama diferente

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


    }
}
