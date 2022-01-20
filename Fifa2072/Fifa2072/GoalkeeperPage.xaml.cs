using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fifa2072
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoalkeeperPage : ContentPage
    {
        public GoalkeeperPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            
        }



        double number1 = 0;
        double number2 = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            Goalkeeper g1 = new Goalkeeper();     
            number1 = number1 + 1;
            number1 = Math.Round(number1, 2);
            string value1 = number1.ToString();
            labelName1.Text = value1;
            number2 = number2 + 1.5;
            number2 = Math.Round(number2, 2);
            string value2 = number2.ToString();
            labelName2.Text = value2;
            if (number1 + number2 / 2 > 60)
            {
                string value = "Twoja karta jest teraz brązowa!!!";
                labelName3.Text = value;
            }
            if (number1 + number2 / 2 > 65)
            {
                string value = "Twoja karta jest teraz srebrna!!!";
                labelName3.Text = value;
            }
            if (number1 + number2 / 2 > 75)
            {
                string value = "Twoja karta jest teraz złota!!!";
                labelName3.Text = value;
            }
            g1.Speed = number1;
            g1.Handling = number2;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            _ = Navigation.PushAsync(new MainPage());
        }
    }
}