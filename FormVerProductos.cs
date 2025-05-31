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
    public partial class FormVerProductos : Form
    {
        public FormVerProductos()
        {
            InitializeComponent();

            toolTip1.SetToolTip(picVolverMenu, "Volver al menú principal");
        }

        string connectionString = ("Server = tcp:proyectoprogramacion.database.windows.net,1433; Initial Catalog = proyectofinal; Persist Security Info = False; User ID = proyectofinal;Password=2025*umg;MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");

       

        private void FormVerProductos_Load(object sender, EventArgs e)
        {

            string query = "SELECT * FROM productos";  

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewProductos.DataSource = dt;
                    dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            menu.Name = "Menu_principal"; // Muestra el menú principal
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string id = text_buscar.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Por favor, ingrese un ID.");
                return;
            }

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM productos WHERE ID = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridViewProductos.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("NO SE ENCONTRÓ EL PRODUCTO.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR DE BUSQUEDA: " + ex.Message);
                }
            }
        }
    }
}
