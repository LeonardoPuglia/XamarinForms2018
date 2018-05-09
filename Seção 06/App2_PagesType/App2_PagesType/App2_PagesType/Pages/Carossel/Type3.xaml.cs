using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_PagesType.Pages.Carossel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Type3 : ContentPage
	{
		public Type3 ()
		{
			InitializeComponent ();
		}

        private void ChangePage(object sender , EventArgs args)
        {
            App.Current.MainPage = new NavigationPage(  new Navigation.Page1() ) { BarBackgroundColor = Color.BlueViolet };
        }

    }
}