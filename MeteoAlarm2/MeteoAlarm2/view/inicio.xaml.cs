using MeteoAlarm2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeteoAlarm2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class inicio : ContentPage
    {
        private string url= "https://retoolapi.dev/2o5yrB/sgcsismos";
        HttpClient cliente = new HttpClient();
        public inicio()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            string contenido = await cliente.GetStringAsync(url);
            IEnumerable<UsuarioModel>  lista = JsonConvert.DeserializeObject<IEnumerable<UsuarioModel>>(contenido);
            lltusuario.ItemsSource = new ObservableCollection<UsuarioModel>(lista); 
            base.OnAppearing();
        }
    }
}