using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace laboratorio13

{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=localhost;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);

            try
            {
                conexion.Open();
                MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");

                // codigo para listar productos
                string query = "SELECT ProductName FROM [dbo].[Products]";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                // Limpia el ListBox antes de llenarlo
                listBox1.Items.Clear();

                // Leer los datos y agregarlos al ListBox
                while (reader.Read())
                {
                    listBox1.Items.Add(reader["ProductName"].ToString());
                }

                reader.Close();

                conexion.Close();
                MessageBox.Show("Se cerró la conexión.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
