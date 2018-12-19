using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Homepage : ContentPage
	{
		public Homepage ()
		{
			InitializeComponent ();
		}

        private async void Tabbed1_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MainParts());
        }
        private async void Tabbed2_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new EditorsChoice());
        }
    }
}