using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyRSVPMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainMenu : ContentPage
	{
		public MainMenu ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Views.AllEvents();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            App.Current.MainPage = new Views.ViewAttendees();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            App.Current.MainPage = new Views.AddEvent();
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            App.Current.MainPage = new Views.Login();
        }
    }
}