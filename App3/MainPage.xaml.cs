using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Envia_Clicked(object sender, EventArgs e)
        {
            string nombre = nombretext.Text;
            string apellido = Apellitext.Text;
            int edad = int.Parse(Edadtext.Text);
            string correo = Correotext.Text;
            await Application.Current.MainPage.Navigation.PushModalAsync(new Pagina2(nombre,apellido,edad,correo));    

        }
    }
}
