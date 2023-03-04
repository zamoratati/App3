using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina2 : ContentPage
	{
		public Pagina2 (string nombre, string apellido, int edad, string correo)
		{
			InitializeComponent ();
			INFO.Text = nombre + apellido + edad + correo;


        }
    }
}