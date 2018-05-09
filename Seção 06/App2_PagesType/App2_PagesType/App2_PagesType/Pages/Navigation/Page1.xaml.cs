using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_PagesType.Pages.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        private void ChangeToSecondPage(object sender , EventArgs args)
        {
            Navigation.PushAsync(new Page2());
        }

        private void OpenModal(object sender , EventArgs args)
        {
            Navigation.PushModalAsync(new Page3());
        }

        private void GoToMaster(object sender , EventArgs args)
        {
            App.Current.MainPage = new Master.Master();
        }

    }
}