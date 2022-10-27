using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhonatanParedes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        private string usuario;

        public Registro()
        {
            InitializeComponent();
        }

        public Registro(string usuario)
        {
            this.usuario = usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            string nombre = txtMonto.Text;
            double monto = Convert.ToDouble(txtMonto.Text);
            double pago = 3000 - monto;
            double pagom = (pago / 5) * 1.05;

            txtPago.Text = pagom.ToString();

            DisplayAlert("Resultado", pagom.ToString(), "cerrar");
        }

        private void btnCalcular_Clicked_1(object sender, EventArgs e)
        {

        }
    }

       
    }