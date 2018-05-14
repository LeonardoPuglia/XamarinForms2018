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
	public partial class EntryPage : ContentPage
	{
		public EntryPage ()
		{
			InitializeComponent ();

            TxtName.TextChanged += delegate(object sender , TextChangedEventArgs args)
            {
                Lbl_Duplicate.Text = args.NewTextValue;
            };

            TxtComment.Completed += delegate (object sender, EventArgs args)
            {
                LblQtdCaracters.Text = TxtComment.Text.Length > 0 ? TxtComment.Text.Trim().Length.ToString() : "0";
            };

            TxtPass.TextChanged += delegate (object sender, TextChangedEventArgs args)
            {
                LblPass.Text = args.NewTextValue;
            };
		}
	}
}