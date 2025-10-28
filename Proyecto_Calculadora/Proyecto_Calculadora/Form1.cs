using System.Data;

namespace Proyecto_Calculadora
{
    public partial class Form1 : Form
    {

        string expression = "";
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

            expression += "4";
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

                
                expr = expr.Replace("÷", "/").Replace("x", "*");

                
                while (expr.Contains("√"))
                {
                    int sqrtIndex = expr.IndexOf("√");
                    int start = sqrtIndex + 2; // Contar despues de "√("
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

                var result = new DataTable().Compute(expr, null);
                textBoxResultado.Text = result.ToString();
                expression = result.ToString();
            }
            catch
            {
                textBoxResultado.Text = "Error";
                expression = "";
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
    }
}


