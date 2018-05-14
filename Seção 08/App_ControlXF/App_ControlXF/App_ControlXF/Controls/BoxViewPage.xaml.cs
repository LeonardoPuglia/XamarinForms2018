using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_ControlXF.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BoxViewPage : ContentPage
	{
		public BoxViewPage ()
		{
			InitializeComponent ();
		}

        private void AddNewBox(object sender , EventArgs args)
        {
            //MainStackBoxViewPage.ChildAdded += new BoxView() { WidthRequest = 150, HeightRequest = 150, Color = Color.Aqua };
        }

    }
}