using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRSVPMobile;
using MyRSVPMobile.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyRSVPMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent();
            BindingContext = new ViewModels.Login();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {

            App.Current.MainPage = new Views.MainMenu();

            
        }
    }
}