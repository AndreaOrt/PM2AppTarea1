using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PM2AD1
{
    public partial class DatosPersonaPage : ContentPage
    {
        public DatosPersonaPage()
        {
            InitializeComponent();
        }

        private async void btnEnviarInfo_Clicked(System.Object sender, System.EventArgs e)
        {
            var nombre = txtNombre.Text;
            var apellidos = txtApellidos.Text;
            var edad = txtEdad.Text;
            var correo = txtCorreo.Text;

            if (System.String.IsNullOrWhiteSpace(nombre) || System.String.IsNullOrWhiteSpace(apellidos) || System.String.IsNullOrWhiteSpace(edad) || System.String.IsNullOrWhiteSpace(correo))
            {
                await this.DisplayAlert("Advertencia", "Ingrese los datos.", "OK");
            }
            else
            {
                var datosPersona = new Models.Persona { Nombre = nombre, Apellidos = apellidos, Edad = Convert.ToInt32(edad), Correo = Convert.ToString(correo) };

                var infoPersonaPage = new InfoPersonaPage();
                infoPersonaPage.BindingContext = datosPersona;
                await Navigation.PushAsync(infoPersonaPage);
            }
        }
    }
}
