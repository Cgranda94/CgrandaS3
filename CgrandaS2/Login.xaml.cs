using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CgrandaS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2022";
            string contrasena = "uisrael2022";

            string tUsuario = txtUsuario.Text;
            string tContrasena = txtContrasena.Text;

            if (usuario==tUsuario & contrasena==tContrasena)
            {
                DisplayAlert("Alerta", "USUARIO CORRECTO " +"Bienvenido: "+usuario, "Cerrar");
                Navigation.PushAsync(new Notas(txtUsuario.Text));
            }
            else
            {
                DisplayAlert("Alerta", "USUARIO INCORRECTO O NO EXISTE", "Cerrar");
            }
        }
    }
}