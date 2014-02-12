using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvelo
{
    [Serializable()]
    public class PénzMozgás
    {
        public string azonosító { get; set; }
        public string név { get; set; }
        public int előirányzat { get; set; }
        public int teljesítés { get; set; }
        public static int évSzám = System.DateTime.Now.Year;

        public PénzMozgás()
        {
            azonosító = "Temp";
            név = "TMP";
            előirányzat = 0;
            teljesítés = 0;
        }

        public PénzMozgás(string azonosító, string név)
        {
            this.azonosító = azonosító;
            this.név = név;
            this.előirányzat = 0;
            this.teljesítés = 0;
        }
        public string ToPString() {



            return "<tr height=\"45\"><td>" + azonosító + "</td><td>" + név + "</td><td>   " + előirányzat + "  &nbsp;&nbsp;&nbsp; </td><td>   " + teljesítés + "  </td></tr>";
        
        
        }
        public string ToP2String()
        {



            return "<tr height=\"45\"><td>" + azonosító + "</td><td>" + név + "</td><td>   " + előirányzat + " </td></tr>";


        }
    }
}
