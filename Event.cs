using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyRSVPMobile.ViewModels 
{
    class Event : INotifyPropertyChanged
    {

        public string _name ="";
        public string address = "", hostname = "";
        public int people;
        public DateTime events1, rsvp1;
        public TimeSpan events2, rsvp2;
        void OnPropertyChanged([CallerMemberName]string name = "")
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        
        public string Name
        {
            get
            { return _name; }

            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
       
        public string Address
        {
            get { return address; }
            set { address = value;
                OnPropertyChanged();
            }
        }
        public int People
        {
            get { return people; }
            set
            {
                people = value;
               OnPropertyChanged();
            }
        }
                
        public string HostName {
            get { return hostname; }
            set { hostname = value;
               OnPropertyChanged();
            }
        }
        public DateTime Events1 {
            get { return events1; }
            set { events1 = value;
                OnPropertyChanged();
            }
        }
        public TimeSpan Events2 {
            get { return events2; }
            set { events2 = value;
                OnPropertyChanged();
            }
        }
        public DateTime RSVP1 {
            get { return rsvp1; }
            set { rsvp1 = value;
               OnPropertyChanged();
            }
        }
        public TimeSpan RSVP2
        {
            get { return rsvp2; }
            set { rsvp2 = value;
                OnPropertyChanged();
            }
        }

        
        

    }
    

    
}
