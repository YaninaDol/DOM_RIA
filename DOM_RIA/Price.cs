using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM_RIA
{
    class Price
    {
        public long Grn { get; set; }
        public long Usd { get; set; }

        public double Per_kB_metr { get; set; }


        public Price(long grn, long usd, double per_kB_metr)
        {
            Grn = grn;
            Usd = usd;
            Per_kB_metr = per_kB_metr;
        }

        public Price():this (0,0,0.0d)
        {
        }
    }
}
