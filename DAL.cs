using System;
using System.Collections.Generic;
using System.Text;
using MyRSVPMobile.ViewModels;

namespace MyRSVPMobile
{
    class DAL
    {
        public SQLite.SQLiteConnection db;
        
        public DAL()
        {

            //created SQLite database

            var pathDB = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "MyRSVPMobile.sqlite");
            db = new SQLite.SQLiteConnection(pathDB);
            
        }

       
        public bool InsertEvent(Event ae1)
        {

            try
            {
                //Create event
                if (db.GetTableInfo("Event").Count == 0)
                {
                    db.CreateTable<Event>();
                }



                int numberOfRows = db.Insert(ae1);
                //Inserted event
                if (numberOfRows > 0)

                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

            public List<Event> getEvents()
            {
                var table = db.Table<Event>();
                return table.ToList();
            }

        public List<RSVP> getAttendees()
        {
            var table1 = db.Table<RSVP>();
            return table1.ToList();
        }
        public bool InsertAttendee(RSVP ae2)
            {

          // db.DropTable<RSVP>();

            //Create event
            if (db.GetTableInfo("RSVP").Count == 0)
            {
                db.CreateTable<RSVP>();
            }

            
            
            
                int numberOfRows1 = db.Insert(ae2);
                //Inserted event
                if (numberOfRows1 > 0)

                 return true; 
                else
                 return false; 
            
                
               
            }
      

    }


 
           
           
            
           


        }
    
