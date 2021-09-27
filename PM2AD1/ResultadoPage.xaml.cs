using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PM2AD1
{
    public partial class ResultadoPage : ContentPage
    {
        public ResultadoPage(Decimal resultado, string infoOperacion)
        {
            InitializeComponent();
            lbInfoOperacion.Text = infoOperacion;
            lbResultado.Text = Convert.ToString(resultado);
        }
    }
}
