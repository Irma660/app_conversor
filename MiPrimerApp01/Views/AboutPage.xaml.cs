using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiPrimerApp01.Views
{
    public partial class AboutPage : ContentPage
    {
        private string operador = null;
        private double? valor1 = null, valor2 = null, resultado = null;
        public AboutPage()
        {
            InitializeComponent();
        }
        void OnSelect(Object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultText.Text == "0" && button.Text != "0")
            {
                resultText.Text = button.Text;
            }
            else if ("0123456789".Contains(button.Text))
            {
                resultText.Text += button.Text;

                if (operador == null)
                {
                    if (valor1 == null)
                    {
                        valor1 = double.Parse(resultText.Text);
                    }
                    else
                    {
                        valor1 = double.Parse(resultText.Text);
                    }
                }
                else
                {
                    if (valor2 == null)
                    {
                        valor2 = double.Parse(resultText.Text);
                    }
                    else
                    {
                        valor2 = double.Parse(resultText.Text);
                    }
                }
            }
            else if ("+-x/".Contains(button.Text))
            {
                if (resultText.Text.EndsWith("+") || resultText.Text.EndsWith("-") || resultText.Text.EndsWith("*") || resultText.Text.EndsWith("/"))
                {
                    resultText.Text = resultText.Text.Remove(resultText.Text.Length - 1) + button.Text;
                }
                else
                {
                    resultText.Text += button.Text;
                }
                operador = button.Text;
            }


            else if (button.Text == "=")
            {
                calcular(valor1, valor2, operador);
            }
        }

        public void calcular(double? v1,double? v2, string op)
        {
            if (v1 != null && v2 != null)
            {
                switch (op)
                {
                    case "/":
                        if (v2 != 0)
                        {
                            double resultado = v1.Value / v2.Value;
                            resultText.Text = resultado.ToString();
                            valor1 = resultado;
                            valor2 = null;
                        }
                        else
                        {
                            resultText.Text = "NO SE PUEDE DIVIDIR";
                        }
                        break;
                    case "x":
                        double resultadoMult = v1.Value * v2.Value;
                        resultText.Text = resultadoMult.ToString();
                        valor1 = resultadoMult;
                        valor2 = null;
                        break;
                    case "+":
                        double resultadoSuma = v1.Value + v2.Value;
                        resultText.Text = resultadoSuma.ToString();
                        valor1 = resultadoSuma;
                        valor2 = null;
                        break;
                    case "-":
                        double resultadoResta = v1.Value - v2.Value;
                        resultText.Text = resultadoResta.ToString();
                        valor1 = resultadoResta;
                        valor2 = null;
                        break;
                    case "%":
                        double resultadoPorcentaje = v1.Value / 100;
                        resultText.Text = resultadoPorcentaje.ToString();
                        valor1 = resultadoPorcentaje;
                        valor2 = null;
                        break;
                }
            }
            }
        void OnClear(object sender, EventArgs e)
        {
            valor1 = null;
            valor2 = null;
            operador = null;
            resultado = null;
            resultText.Text = "0";
        }
        void OnClearr(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultText.Text))
            {
                resultText.Text = resultText.Text.Substring(0, resultText.Text.Length - 1); // Eliminar el último carácter
            }
        }
        private void OnResult(object sender, EventArgs e)
        {
            if (valor1 != null && valor2 != null && operador != null)
            {
                calcular(valor1, valor2, operador);
            }
        }


    }
}