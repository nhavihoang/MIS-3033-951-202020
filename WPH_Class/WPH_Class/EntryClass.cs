using System;
using System.Collections.Generic;
using System.Text;

namespace WPH_Class
{
    public class EntryClass
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Zipcode { get; set; }


        public EntryClass()
        {
            Name = string.Empty;
            Address = string.Empty;
            Zipcode = 0;
        }

        public EntryClass(int Zip, string Addy, string Name1)
        {
            Zipcode = Zip;
            Address = Addy;
            Name = Name1;


        }





    }




}
