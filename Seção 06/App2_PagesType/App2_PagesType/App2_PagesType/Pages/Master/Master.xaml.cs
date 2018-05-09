using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_PagesType.Pages.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void ChangePageOne(object sender, EventArgs args)
        {
            Detail = new NavigationPage( new Navigation.Page1() );
            IsPresented = false;
        }

        private void ChangePageTwo(object sender, EventArgs args)
        {
            Detail = new Navigation.Page2();
            IsPresented = false;
        }

        private void ChangePageContent(object sender , EventArgs args)
        {
            Detail = new Conteudo();
            IsPresented = false;
        }


    }
}