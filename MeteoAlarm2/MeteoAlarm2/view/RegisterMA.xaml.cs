using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeteoAlarm2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterMA : ContentPage
    {
        public RegisterMA()
        {
            InitializeComponent();
        }

        private async void btnRegistro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabbedPage1());
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}