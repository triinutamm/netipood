using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netipood
{
    public class Kohv
    {

        public string kohvisort { get; set; }
        public string kohvikogus { get; set; }
        public string kohvihind { get; set; }
        public double hind1 { get; set; }

        public Kohv(string sort, int kogus, double hind)
        {
            kohvisort = sort;
            kohvikogus = kogus + " tk";
            kohvihind = kogus * hind + " €";
            hind1 = kogus * hind;

        }
    }
}

