using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM2AD1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSuma_Clicked(System.Object sender, System.EventArgs e)
        {
            var num1 = txtNum1.Text;
            var num2 = txtNum2.Text;

            if (System.String.IsNullOrWhiteSpace(num1) || System.String.IsNullOrWhiteSpace(num2)){
                await this.DisplayAlert("Advertencia", "Ingrese los números para realizar una operación.", "OK");
            }
            else
            {
                await Navigation.PushAsync(new ResultadoPage(Convert.ToDecimal(num1) + Convert.ToDecimal(num2), "El resultado de la suma es:"));
            }
        }


        private async void btnResta_Clicked(System.Object sender, System.EventArgs e)
        {
            var num1 = txtNum1.Text;
            var num2 = txtNum2.Text;

            if (System.String.IsNullOrWhiteSpace(num1) || System.String.IsNullOrWhiteSpace(num2))
            {
                await this.DisplayAlert("Advertencia", "Ingrese los números para realizar una operación.", "OK");
            }
            else
            {
                await Navigation.PushAsync(new ResultadoPage(Convert.ToDecimal(num1) - Convert.ToDecimal(num2), "El resultado de la resta es:"));
            }
        }

        private async void btnDivision_Clicked(System.Object sender, System.EventArgs e)
        {
            var num1 = txtNum1.Text;
            var num2 = txtNum2.Text;

            if (System.String.IsNullOrWhiteSpace(num1) || System.String.IsNullOrWhiteSpace(num2))
            {
                await this.DisplayAlert("Advertencia", "Ingrese los números para realizar una operación.", "OK");
            }
            else
            {
                await Navigation.PushAsync(new ResultadoPage(Convert.ToDecimal(num1) / Convert.ToDecimal(num2), "El resultado de la división es:"));
            }
        }

        private async void btnMultiplicacion_Clicked(System.Object sender, System.EventArgs e)
        {
            var num1 = txtNum1.Text;
            var num2 = txtNum2.Text;

            if (System.String.IsNullOrWhiteSpace(num1) || System.String.IsNullOrWhiteSpace(num2))
            {
                await this.DisplayAlert("Advertencia", "Ingrese los números para realizar una operación.", "OK");
            }
            else
            {
                await Navigation.PushAsync(new ResultadoPage(Convert.ToDecimal(num1) * Convert.ToDecimal(num2), "El resultado de la multiplicación es:"));
            }
        }
    }
}
