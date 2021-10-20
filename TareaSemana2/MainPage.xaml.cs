using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TareaSemana2
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario, string pass)
        {
            InitializeComponent();
            lblusuario.Text = usuario;
            //lblpass.Text = pass;
            
        }

        public void btnSumar1_Clicked(object sender, EventArgs e)
        {
            double notap1 = Convert.ToDouble(txtnota1.Text);
            double examenp1 = Convert.ToDouble(txtexamen1.Text);
            double parcial1 = (notap1 * 0.3) + (examenp1 * 0.2);
            txtparcial1.Text = parcial1.ToString();

        }

        public void btnSumar2_Clicked(object sender, EventArgs e)
        {
            double notap2 = Convert.ToDouble(txtnota2.Text);
            double examenp2 = Convert.ToDouble(txtexamen2.Text);
            double parcial2 = (notap2 * 0.3) + (examenp2 * 0.2);
            txtparcial2.Text = parcial2.ToString();

        }

        public void btnPromedio_Clicked(object sender, EventArgs e)
        {
            double suma1 = Convert.ToDouble(txtparcial1.Text);
            double suma2 = Convert.ToDouble(txtparcial2.Text);
            double total = (suma1 + suma2);
            txttotal.Text = total.ToString();

            string estadoA = "APROBADO";
            string estadoB = "COMPLEMENTARIO";
            string estadoC = "REPROBADO";

            if (total >= 7)
            {
                txtestado.Text = estadoA.ToString();
            }
            else
            if (total >= 5 && total <= 6.9)
            {
                txtestado.Text = estadoB.ToString();
            }
            else
            {
                txtestado.Text = estadoC.ToString();
            }
        }


        private void txtnota1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Convert.ToDouble(txtnota1.Text) > 10)
            {
                DisplayAlert("Advertencia", "Solo puede ingresar notas de 1 a 10", "OK");
            }

        }

        private void txtexamen1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Convert.ToDouble(txtexamen1.Text) > 10)
            {
                DisplayAlert("Advertencia", "Solo puede ingresar notas de 1 a 10", "OK");
            }
        }

        private void txtnota2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Convert.ToDouble(txtnota2.Text) > 10)
            {
                DisplayAlert("Advertencia", "Solo puede ingresar notas de 1 a 10", "OK");
            }
        }

        private void txtexamen2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Convert.ToDouble(txtexamen2.Text) > 10)
            {
                DisplayAlert("Advertencia", "Solo puede ingresar notas de 1 a 10", "OK");
            }
        }

    }
}
