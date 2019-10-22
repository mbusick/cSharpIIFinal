using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstApplication
{
    public class Employee
    {
        public Employee()
        {
            FName = "";
            LName = "";
            StreetAddress = "";
            City = "";
            State = "";
            Zip = "";
        }

        public string FName { get; set; }
        public string LName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

    }
}
