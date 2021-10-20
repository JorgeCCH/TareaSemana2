using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaSemana2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Acceso : ContentPage
    {
        public Acceso()
        {
            InitializeComponent();
            
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string pass = txtpass.Text;

            string usu = "estudiante2021";
            string cla = "uisrael2021";

            if (usuario == usu && pass == cla)
            {
                await Navigation.PushAsync(new MainPage(usuario, pass));

            }
            else
            {
               await DisplayAlert("Advertencia", "El nombre de usuario o contraseña son incorrectos", "OK");
            }

        }
    }
}