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
    public partial class Notas : ContentPage
    {
        public Notas(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "El usuario conectado es: "+ usuario;
        }

        private void btnParcial_Clicked(object sender, EventArgs e)
        {
            double notaseguimiento = Convert.ToDouble(txtParcial1.Text);
            double notaexamen = Convert.ToDouble(txtExamen1.Text);
            double ns = notaseguimiento * 0.3;
            double ne = notaexamen * 0.2;
            double parcial = ns + ne;

            DisplayAlert("Alerta","Su nota del primer parcial es" +parcial.ToString(), "Cerrar");
            txtResultado1.Text = parcial.ToString();

        }

        private void txtParcial1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double p1,e1;
            p1 = Convert.ToDouble(txtParcial1.Text);
            
            if (p1 > 10)
            {
                
                DisplayAlert("Alerta", "SOLO SE ADMITEN VALORES DE 1-10", "Cerrar");
                
                


            }
            
            

        }

        private void btnParcial2_Clicked(object sender, EventArgs e)
        {
            double notaseguimiento2 = Convert.ToDouble(txtParcial2.Text);
            double notaexamen2 = Convert.ToDouble(txtExamen2.Text);
            double ns2 = notaseguimiento2 * 0.3;
            double ne2 = notaexamen2 * 0.2;
            double parcial2 = ns2 + ne2;

            DisplayAlert("Alerta", "Su nota del segundo parcial es: " + parcial2.ToString(), "Cerrar");
            txtResultado2.Text = parcial2.ToString();
        }

        private void btnFinal_Clicked(object sender, EventArgs e)
        {
            double parcial1 = Convert.ToDouble(txtResultado1.Text);
            double parcial2 = Convert.ToDouble(txtResultado2.Text);
            double notafinal = parcial1 + parcial2;
            if (notafinal >=7)
            {
                DisplayAlert("Alerta", "APROBADO Su nota final es: " + notafinal.ToString(),"Cerrar");
                txtFinal.Text = notafinal.ToString();
            }
            else if (notafinal >=5 & notafinal<=6.9)
            {
                DisplayAlert("Alerta", "COMPLEMENTARIO Su nota final es: " + notafinal.ToString(), "Cerrar");
                txtFinal.Text = notafinal.ToString();
            }
            else
            {
                DisplayAlert("Alerta", "REPROBADO Su nota final es: " + notafinal.ToString(), "Cerrar");
                txtFinal.Text = notafinal.ToString();
            }
                

        }
            
        }
    }
