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
    public partial class Resumen : ContentPage
    {
        public Resumen()
        {
        }

        public Resumen(string luser, string names, string total)
        {
            InitializeComponent();

            usuario.Text = "Usuario conectado: " + luser;
            name_val.Text = "Nombres Estudiantes: " + names;
            insc_val.Text = "Cuota Mensual: " + total;
        }
        
    
        
    }
}