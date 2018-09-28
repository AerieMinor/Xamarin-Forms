using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyRSVPMobile.ViewModels
{
    class RSVP: INotifyPropertyChanged
    {
       public string name1, emailAddress;
        public int mobile;

        void OnPropertyChanged([CallerMemberName]string name1 = "")
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name1));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name1 {
            get { return name1; }

            set { name1 = value; OnPropertyChanged(); }
            
            
        }
        public int Mobile {
            get { return mobile; }

            set { mobile = value; OnPropertyChanged(); }
        }
        public string EmailAddress {
            get { return emailAddress; }

            set { emailAddress = value; OnPropertyChanged(); }
        }

    }
}
