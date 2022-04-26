using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM_RIA
{
    class Rieltor
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Fathername { get; set; } 
        public string Phone_number { get; set; }

        public float Reiting { get; set; }

        public Rieltor(string surname, string name, string fathername, string phone_number, float reiting)
        {
            Surname = surname;
            Name = name;
            Fathername = fathername;
            Phone_number = phone_number;
            Reiting = reiting;
        }

        public Rieltor():this(" "," "," "," ",0.0f)
        {
        }

    }
}
