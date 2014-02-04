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
        public string azonosítóMásodikSzint { get; set; }
        public string azonosítóHarmadikSzint { get; set; }
        public string azonosítóNegyedikSzint { get; set; }
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

        public PénzMozgás(string azonosító, string azonosítóMásodikSzint, string név)
        {
            this.azonosító = azonosító;
            this.azonosítóMásodikSzint = azonosítóMásodikSzint;
            this.név = név;
            this.előirányzat = 0;
            this.teljesítés = 0;
        }

        public PénzMozgás(string azonosító, string azonosítóMásodikSzint, string azonosítóHarmadikSzint, string név)
        {
            this.azonosító = azonosító;
            this.azonosítóMásodikSzint = azonosítóMásodikSzint;
            this.azonosítóHarmadikSzint = azonosítóHarmadikSzint;
            this.név = név;
            this.előirányzat = 0;
            this.teljesítés = 0;
        }

        public PénzMozgás(string azonosító, string azonosítóMásodikSzint, string azonosítóHarmadikSzint,
            string azonosítóNegyedikSzint, string név)
        {
            this.azonosító = azonosító;
            this.azonosítóMásodikSzint = azonosítóMásodikSzint;
            this.azonosítóHarmadikSzint = azonosítóHarmadikSzint;
            this.azonosítóNegyedikSzint = azonosítóNegyedikSzint;
            this.név = név;
            this.előirányzat = 0;
            this.teljesítés = 0;
        }

        public PénzMozgás(string azonosító, string név, int előirányzat, int teljesítés)
        {
            this.azonosító = azonosító;
            this.azonosítóMásodikSzint = azonosítóMásodikSzint;
            this.azonosítóHarmadikSzint = azonosítóHarmadikSzint;
            this.azonosítóNegyedikSzint = azonosítóNegyedikSzint;
            this.név = név;
            this.előirányzat = előirányzat;
            this.teljesítés = teljesítés;
        }
    }
}
