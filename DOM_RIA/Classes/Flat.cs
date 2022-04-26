using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM_RIA
{
    class Flat
    {
       

        public Geo_location Location { get; set; }
        public Price Price { get; set; }
        public Flat_information Information { get; set; }

        public Flat(Geo_location location, Price price, Flat_information information)
        {
            Location = location;
            Price = price;
            Information = information;
        }
        public Flat():this(new Geo_location(),new Price(),new Flat_information())
        {

        }

    }
}
