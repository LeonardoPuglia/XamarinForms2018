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
	public partial class ProgressiveBarPage : ContentPage
	{
		public ProgressiveBarPage ()
		{
			InitializeComponent ();
		}

        private void ModifyProgressBar(object sender, EventArgs args)
        {
            BarOne.ProgressTo(1, 9000 , Easing.SinOut);
            BarTwo.ProgressTo(1, 5000 , Easing.Linear);// in Milliseconds
            BarThree.ProgressTo(1, 5000, Easing.SpringIn);//Third Param is Animation
        }

        private void ResetProgressBar(object sender, EventArgs args)
        {
            BarOne.ProgressTo(.1, 1000, Easing.SinIn);
            BarTwo.ProgressTo(.1, 10000, Easing.BounceIn);
            BarThree.ProgressTo(.1, 5000, Easing.CubicIn);
        }

        private void ResetFuckProgressBar(object sender, EventArgs args)
        {
            BarOne.Progress = 0;
            BarTwo.Progress = 0;
            BarThree.Progress = 0;
        }

    }
}