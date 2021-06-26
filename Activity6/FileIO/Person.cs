using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string url { get; set; }


        public Person()
        {
            firstName = "";
            lastName = "";
            url = "";
        }

        public Person(string a, string b, string c)
        {
            firstName = a;
            lastName = b;
            url = c;
        }

        public override string ToString()
        {
            return "First Name: " + firstName + " Last Name: " + lastName + " URL: " + url;
        }
    }
}
