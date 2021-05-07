using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Odev
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double vizeNotu = 0, odevNotu = 0, finelNotu = 0;
            //double.TryParse(VizeNotu.Text, out vizeNotu);
            //double.TryParse(OdevNotu.Text, out odevNotu);
            //double.TryParse(FinelNotu.Text, out finelNotu);
            if (string.IsNullOrWhiteSpace(VizeNotu.Text) || !Double.TryParse(VizeNotu.Text, out vizeNotu))
            {
                DisplayAlert("Dikket !!", "Vize Notunuz yazmadınız", "Tamam");
                return;
            }
            else if (string.IsNullOrWhiteSpace(OdevNotu.Text) || !Double.TryParse(OdevNotu.Text, out odevNotu))
            {
                DisplayAlert("Dikket !!", "Odev Notunuz yazmadınız", "Tamam");
                return;
            }
            else if (string.IsNullOrWhiteSpace(FinelNotu.Text) || !Double.TryParse(FinelNotu.Text, out finelNotu))
            {
                DisplayAlert("Dikket !!", "Finel Notunuz yazmadınız", "Tamam");
                return;
            }

            var x = OdevVizeNotuYuzdesi.Value;
            var y = FinelNotuYuzdesi.Value;
            var toplam = (((vizeNotu + odevNotu) / 2) * x + finelNotu * y)/100;
            HBN.Text = Math.Round(toplam, 2).ToString();
            string temp;
            Color color = new Color();
            if (toplam >= 88 && toplam <= 100)
            {
                color = Color.Green;
                temp = "AA";
            }
            else if (toplam >= 80 && toplam < 88)
            {
                temp = "BA";
            }
            else if (toplam >= 73 && toplam < 80)
            {
                temp = "BB";
            }
            else if (toplam >= 66 && toplam < 73)
            {
                temp = "CB";
            }
            else if (toplam >= 60 && toplam < 66)
            {
                temp = "CC";
            }
            else if (toplam >= 55 && toplam < 60)
            {
                temp = "DC";
            }
            else if (toplam >= 50 && toplam < 55)
            {
                temp = "DD";
            }
            else if (toplam >= 0 && toplam < 50)
            {
                color = Color.Red;
                temp = "FF";
            }
            else
            {
                temp = "--";
            }
            HarfNotu.TextColor = color;
            HarfNotu.Text = temp;

        }
    }
}
