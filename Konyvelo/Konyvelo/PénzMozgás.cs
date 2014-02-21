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
        public string ToPString(string sormagasság) {



            return "<tr height=\"" + sormagasság + "\"><td>" + azonosító + "</td><td>" + név + "</td><td>   " + Tagol(előirányzat) + "  &nbsp;&nbsp;&nbsp; </td><td>   " + Tagol(teljesítés) + "  </td></tr>";
        
        
        }

        public static string Tagol(int teljesítés)
        {
            return teljesítés.ToString("N0");//ezres tagolás
        }
        public string ToP2String(string sormagasság)
        {



            return "<tr height=\""+sormagasság+"\"><td>" + azonosító + "</td><td>" + név + "</td><td>   " + Tagol(előirányzat) + " </td></tr>";


        }
    }
}
