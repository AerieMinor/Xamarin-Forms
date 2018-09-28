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
	public partial class RSVP : ContentPage
	{
		public RSVP ()
		{
			InitializeComponent ();
            BindingContext = new ViewModels.RSVP();

            

         }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Views.MainMenu();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DAL dba = new DAL();
            bool att = dba.InsertAttendee((ViewModels.RSVP)this.BindingContext);
            //dba.InsertEvent(evt);
            if (att)
            {
                App.Current.MainPage = new Views.ViewAttendees();
            }
            //App.Current.MainPage = new Views.ViewAttendees();
        }

        
    }
}