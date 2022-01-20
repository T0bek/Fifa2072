using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Fifa2072
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void pickerButton_Clicked(object sender, EventArgs e)
        {
            if (picker.SelectedIndex == 0)
            {
                Navigation.PushAsync(new GoalkeeperPage());
            }
            if (picker.SelectedIndex == 1)
            {
                Navigation.PushAsync(new DefenderPage());
            }
            if (picker.SelectedIndex == 2)
            {
                Navigation.PushAsync(new MidfielderPage());
            }
            if (picker.SelectedIndex == 3)
            {
                Navigation.PushAsync(new StrikerPage());
            }
        }
    }
}
