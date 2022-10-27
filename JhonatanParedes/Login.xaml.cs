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
    public partial class Login : ContentPage
    {
        private Registro registro;

        public Login()
        {
            InitializeComponent();
        }

        public Login(Registro registro)
        {
            this.registro = registro;
        }

        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());
            string usuario = "JP2022";
            string contraseña = "uisrael2022";

            string tUsuario = txtUsuario.Text;
            string tContraseña = txtContraseña.Text;
            if (usuario == tUsuario & contraseña == tContraseña)
            {
                await DisplayAlert("Alerta", "USUARIO CORRECTO", "CERRAR");
            }
            else 
            {
                await DisplayAlert("Alerta", "USUARIO NO EXISTE", "CERRAR");
            }
        }
    }

    internal class registro : Page
    {
    }
}