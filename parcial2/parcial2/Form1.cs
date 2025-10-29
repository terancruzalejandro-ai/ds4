using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace parcial2
{
    public partial class Conversor : Form
    {

        string connectionString = @"Server=localhost;Database=PARCIAL2DB;Trusted_Connection=True;";

        // tasas
        private const decimal EURO_TO_DOLAR = 1.17m;
        private const decimal DOLAR_TO_PESO = 4258m;
        private const decimal EURO_TO_PESO = EURO_TO_DOLAR * DOLAR_TO_PESO;

        public Conversor()
        {
            InitializeComponent();

            // eventos de los botones
            btnEuroToAll.Click += btnEuroToAll_Click;
            btnDolarToAll.Click += btnDolarToAll_Click;
            btnPesoToall.Click += btnPesoToall_Click;
        }


        private void btnEuroToAll_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtEuroToAll.Text, out decimal monto))
            {
                decimal aDolar = monto * EURO_TO_DOLAR;
                decimal aPeso = monto * EURO_TO_PESO;

                textBox4.Text = monto.ToString("N2"); // euros
                textBox5.Text = aDolar.ToString("N2"); // dólares
                textBox6.Text = aPeso.ToString("N2");  // pesos

                GuardarConversion("EUR", "USD", monto, aDolar, EURO_TO_DOLAR);
                GuardarConversion("EUR", "COP", monto, aPeso, EURO_TO_PESO);
            }
            else
            {
                MessageBox.Show("Ingrese un valor numerico");
            }
        }

        private void btnDolarToAll_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDolarToAll.Text, out decimal monto))
            {
                decimal aEuro = monto / EURO_TO_DOLAR;
                decimal aPeso = monto * DOLAR_TO_PESO;

                textBox7.Text = aEuro.ToString("N2");
                textBox8.Text = monto.ToString("N2");
                textBox9.Text = aPeso.ToString("N2");

                GuardarConversion("USD", "EUR", monto, aEuro, 1 / EURO_TO_DOLAR);
                GuardarConversion("USD", "COP", monto, aPeso, DOLAR_TO_PESO);
            }
            else
            {
                MessageBox.Show("Ingrese un valor numerico");
            }
        }

        private void btnPesoToall_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPesoToAll.Text, out decimal monto))
            {
                decimal aDolar = monto / DOLAR_TO_PESO;
                decimal aEuro = monto / EURO_TO_PESO;

                textBox10.Text = aEuro.ToString("N2");
                textBox11.Text = aDolar.ToString("N2");
                textBox12.Text = monto.ToString("N2");

                GuardarConversion("COP", "USD", monto, aDolar, 1 / DOLAR_TO_PESO);
                GuardarConversion("COP", "EUR", monto, aEuro, 1 / EURO_TO_PESO);
            }
            else
            {
                MessageBox.Show("Ingrese un valor numerico.");
            }
        }



        private void GuardarConversion(string origen, string destino, decimal monto, decimal resultado, decimal tasa)
        {
            string query = "INSERT INTO Conversiones (MonedaOrigen, MonedaDestino, Monto, Resultado, Tasa) " +
                           "VALUES (@o, @d, @m, @r, @t)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@o", origen);
                    cmd.Parameters.AddWithValue("@d", destino);
                    cmd.Parameters.AddWithValue("@m", monto);
                    cmd.Parameters.AddWithValue("@r", resultado);
                    cmd.Parameters.AddWithValue("@t", tasa);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en la base de datos:\n" + ex.Message);
            }
        }



        private void btnHistorial_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("HISTORIAL DE CONVERSIONES:");
            

            string query = "SELECT TOP 20 MonedaOrigen, MonedaDestino, Monto, Resultado, Tasa, Fecha " +
                           "FROM Conversiones ORDER BY Fecha DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("No hay conversiones registradas.");
                        return;
                    }

                    while (reader.Read())
                    {
                        string linea = $"{reader["Monto"],8:N2} {reader["MonedaOrigen"]}  →  {reader["Resultado"],8:N2} {reader["MonedaDestino"]}  (Tasa: {reader["Tasa"]})";
                        sb.AppendLine(linea);
                    }

                    reader.Close();
                }

                MessageBox.Show(sb.ToString(), "Historial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener historial:\n" + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {

            txtEuroToAll.Clear();
            txtDolarToAll.Clear();
            txtPesoToAll.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
