using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRSVPMobile.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyRSVPMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AllEvents : ContentPage
	{
        public AllEvents()
        {
            InitializeComponent();
            DAL dba = new DAL();

            List<Event> events = new List<Event>();
            events = new List<Event>(dba.getEvents());

            aevents.ItemsSource = events;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Views.MainMenu();
        }

        private void aevents_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DateTime eventdate = DateTime.Today;

            if(((Event)e.SelectedItem).RSVP1 > eventdate)
            {

                App.Current.MainPage = new Views.RSVP();

            }

            else
            {
                DisplayAlert("Alert", "You can't RSVP: Date has passed. Try another event!", "Sorry!");
            }

        }
    }
}