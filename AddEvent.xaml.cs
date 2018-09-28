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
	public partial class AddEvent : ContentPage
	{
		public AddEvent ()
		{
			InitializeComponent ();
            BindingContext = new Event();
		}
        public void OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblid.Text = string.Format("# of people: {0}", e.NewValue);    
            

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DAL dba = new DAL();
            bool evt = dba.InsertEvent((Event)this.BindingContext);


            //dba.InsertEvent(evt);
            if (evt)
            {
                App.Current.MainPage = new Views.AllEvents();
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            App.Current.MainPage = new Views.MainMenu();
        }

        
        
    }

    
}