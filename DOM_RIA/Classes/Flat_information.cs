using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM_RIA
{
    class Flat_information
    {
        public int RoomCount { get; set; }
        public int Floor { get; set; }
        public double Square { get; set; }
        public string Furnished { get; set; }

        public Flat_information(int roomCount, int floor, double square, string furnished)
        {
            RoomCount = roomCount;
            Floor = floor;
            Square = square;
            Furnished = furnished;
        }

        public Flat_information():this (0,0,0.0d," ")
        {
        }


    }
}
