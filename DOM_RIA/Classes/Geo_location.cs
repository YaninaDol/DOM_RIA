using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM_RIA
{
    class Geo_location
    {
       
        public string  City { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public Geo_location(string city, string region, string street, string number)
        {
            City = city;
            Region = region;
            Street = street;
            Number = number;
        }

        public Geo_location():this(" "," "," "," ")
        {
        }


    }
}
