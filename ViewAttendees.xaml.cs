using MyRSVPMobile.ViewModels;
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
	public partial class ViewAttendees : ContentPage
	{
		public ViewAttendees ()
		{
			InitializeComponent ();

            DAL dba = new DAL();
            
                List<ViewModels.RSVP> attendees = new List<ViewModels.RSVP>();
                attendees = new List<ViewModels.RSVP>(dba.getAttendees());

                ae1vents.ItemsSource = attendees;
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Views.MainMenu();
        }

        
    }
}