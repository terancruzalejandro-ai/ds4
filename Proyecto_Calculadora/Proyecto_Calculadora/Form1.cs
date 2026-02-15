using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Calculadora
{
    public partial class Form1 : Form
    {

        string expression = "";
        string connectionString = @"Server=localhost;Database=CalculadoraDB;Trusted_Connection=True;";

        public Form1()

        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            expression += "2";
            textBoxResultado.Text = expression;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            expression += "0";
            textBoxResultado.Text = expression;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            expression += "3";
            textBoxResultado.Text = expression;

        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {

            if (expression.Length > 0)
            {
                expression = expression.Substring(0, expression.Length - 1);
                textBoxResultado.Text = expression;
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

            expression = "";
            textBoxResultado.Text = "";

        }

        private void button9_Click(object sender, EventArgs e)
        {

            expression += "9";
            textBoxResultado.Text = expression;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {

            expression += ".";
            textBoxResultado.Text = expression;

        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            try
            {
                string expr = expression;

                // Reemplaza simbolos
                expr = expr.Replace("÷", "/").Replace("x", "*");

                // Calcular potencia
                while (expr.Contains("^"))
                {
                    int powIndex = expr.IndexOf("^");

                    // Encontrar el número a la izquierda del ^
                    int leftStart = powIndex - 1;
                    while (leftStart >= 0 && (char.IsDigit(expr[leftStart]) || expr[leftStart] == '.' || expr[leftStart] == ')'))
                    {
                        if (expr[leftStart] == '(' && leftStart < powIndex - 1) break;
                        leftStart--;
                    }
                    leftStart = Math.Max(0, leftStart + 1);

                    string leftStr = expr.Substring(leftStart, powIndex - leftStart).Replace("(", "");

                    // Encontrar el número a la derecha del ^
                    int rightStart = powIndex + 1;
                    int rightEnd = rightStart;
                    while (rightEnd < expr.Length && (char.IsDigit(expr[rightEnd]) || expr[rightEnd] == '.' || expr[rightEnd] == '(' || expr[rightEnd] == ')'))
                    {
                        if (expr[rightEnd] == ')' && rightEnd > rightStart) break;
                        rightEnd++;
                    }

                    string rightStr = expr.Substring(rightStart, rightEnd - rightStart).Replace(")", "");

                    // Calcular la potencia
                    double baseNum = Convert.ToDouble(leftStr);
                    double exponent = Convert.ToDouble(rightStr);
                    double powResult = Math.Pow(baseNum, exponent);

                    expr = expr.Substring(0, leftStart) + powResult.ToString() + expr.Substring(rightEnd);
                }

                // Calcular raiz cuadrada 
                while (expr.Contains("√"))
                {
                    int sqrtIndex = expr.IndexOf("√");
                    int start = sqrtIndex + 2;
                    int end = start;

                    while (end < expr.Length && (char.IsDigit(expr[end]) || expr[end] == '.' || expr[end] == '(' || expr[end] == ')'))
                    {
                        if (expr[end] == ')' && end > start) break;
                        end++;
                    }

                    string inside = expr.Substring(start, end - start).Replace(")", "");
                    double sqrtResult = Math.Sqrt(Convert.ToDouble(inside));
                    expr = expr.Substring(0, sqrtIndex) + sqrtResult.ToString() + expr.Substring(end);
                }

                // Evalua la expresion
                var result = new DataTable().Compute(expr, null);
                textBoxResultado.Text = result.ToString();
                expression = result.ToString();

                // Guarda en base de datos
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Historial (Expresion, Resultado) VALUES (@expr, @res)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@expr", expr);
                    cmd.Parameters.AddWithValue("@res", result.ToString());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                textBoxResultado.Text = "Error";
                expression = "";
                MessageBox.Show("Error al calcular o guardar: " + ex.Message);
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            expression += "1";
            textBoxResultado.Text = expression;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            expression += "2";
            textBoxResultado.Text = expression;

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            expression += "4";
            textBoxResultado.Text = expression;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            expression += "5";
            textBoxResultado.Text = expression;

        }

        private void button6_Click(object sender, EventArgs e)
        {

            expression += "6";
            textBoxResultado.Text = expression;

        }

        private void button7_Click(object sender, EventArgs e)
        {

            expression += "7";
            textBoxResultado.Text = expression;

        }

        private void button8_Click(object sender, EventArgs e)
        {

            expression += "8";
            textBoxResultado.Text = expression;

        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {

            expression += "+";
            textBoxResultado.Text = expression;

        }

        private void buttonResta_Click(object sender, EventArgs e)
        {

            expression += "-";
            textBoxResultado.Text = expression;

        }

        private void buttonMultiplica_Click(object sender, EventArgs e)
        {

            expression += "x";
            textBoxResultado.Text = expression;

        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {

            expression += "÷";
            textBoxResultado.Text = expression;

        }

        private void buttonElevarCuadrado_Click(object sender, EventArgs e)
        {

            expression += "^2";
            textBoxResultado.Text = expression;


        }

        private void buttonRaiz_Click(object sender, EventArgs e)
        {

            expression += "√(";
            textBoxResultado.Text = expression;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Historial ORDER BY Id DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("No hay registros en el historial aún.", "Historial vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string historial = "HISTORIAL DE OPERACIONES:\n\n";
                while (reader.Read())
                {
                    historial += $"{reader["Fecha"]}: {reader["Expresion"]} = {reader["Resultado"]}\n";
                }

                reader.Close();
                MessageBox.Show(historial, "Historial de la Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }


