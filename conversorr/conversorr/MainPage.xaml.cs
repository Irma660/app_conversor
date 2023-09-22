using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace conversorr
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnConvertClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputEntry.Text))
            {
                resultLabel.Text = "Ingrese un valor válido";
                return;
            }

            double inputValue = double.Parse(inputEntry.Text);
            string fromUnit = fromUnitPicker.SelectedItem.ToString();
            string toUnit = toUnitPicker.SelectedItem.ToString();

            double result = 0.0;

            if (fromUnit == "Kilogramos" && toUnit == "Libras")
            {
                result = inputValue * 2.20462;
            }
            else if (fromUnit == "Litros" && toUnit == "Galones")
            {
                result = inputValue * 0.264172;
            }
            else if (fromUnit == "Grados Celsius" && toUnit == "Grados Fahrenheit")
            {
                result = (inputValue * 9 / 5) + 32;
            }

            resultLabel.Text = $"{inputValue} {fromUnit} es igual a {result} {toUnit}";
            resultLabel.Text = $"{inputValue} {fromUnit} es igual a {result} {toUnit}";

            
            inputEntry.Text = string.Empty;
            fromUnitPicker.SelectedIndex = -1;
            toUnitPicker.SelectedIndex = -1;
        }
    }
}


