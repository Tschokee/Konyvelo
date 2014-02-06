using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvelo
{
    public class PénzMozgás
    {
        public string azonosító { get; set; }
        public string név { get; set; }
        public int előirányzat { get; set; }
        public int teljesítés { get; set; }

        public PénzMozgás()
        {
            azonosító = "Temp";
            név = "TMP";
            előirányzat = 1000;
            teljesítés = 2000;
        }

        public PénzMozgás(string azonosító, string név)
        {
            this.azonosító = azonosító;
            this.név = név;
            this.előirányzat = 0;
            this.teljesítés = 0;
        }
    }
}
