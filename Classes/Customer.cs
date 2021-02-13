using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {

        // Field (Alan)
        // public string FirstName;

        // Property (Özellik)
        public int Id { get; set; }
        public string FirstName { get; set; }
        //private string _firstName;
        //public string FirstName { 
        //    get { return "Mr. " + _firstName; }
        //    set { _firstName = value; }
        //}
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
