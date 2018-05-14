using App_ControlXF.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_ControlXF.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void GoActivityIndicatorPage(object sender , EventArgs args)
        {
            Detail = new ActivityIndicatorPage();
            IsPresented = false;
        }

        private void GoProgressiveBar(object sender, EventArgs args)
        {
            Detail = new ProgressiveBarPage();
            IsPresented = false;
        }

        private void GoBoxView(object sender, EventArgs args)
        {
            Detail = new BoxViewPage();
            IsPresented = false;
        }
        private void GoLabelPage(object sender, EventArgs args)
        {
            Detail = new LabelPage();
            IsPresented = false;
        }
        private void GoButtonPage(object sender, EventArgs args)
        {
            Detail = new ButtonPage();
            IsPresented = false;
        }

        private void GoEntryPage(object sender, EventArgs args)
        {
            Detail = new EntryPage();
            IsPresented = false;
        }
        





    }
}