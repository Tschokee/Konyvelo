using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvelo
{
    public class Bejegyzés
    {
        public int sorSzám { get; set; }
        public string fizetésIdeje { get; set; }
        public string megjegyzés { get; set; }
        public KöltségvetésiCím főkönyv { get; set; }
        public int bankiBevétel { get; set; }
        public int bankiKiadás { get; set; }
        public static int bankiEgyenleg = 0; 
        public int pénztáriBevétel { get; set; }
        public int pénztáriKiadás { get; set; }
        public static int pénztáriEgyenleg = 0;

        public Bejegyzés(int sorSzám, string fizetésIdeje, string megjegyzés, KöltségvetésiCím főkönyv, int bankiBevétel, int bankiKiadás, int pénztáriBevétel, int pénztáriKiadás)
        {
            this.sorSzám = sorSzám;
            this.fizetésIdeje = fizetésIdeje;
            this.megjegyzés = megjegyzés;
            this.főkönyv = főkönyv;
            this.bankiBevétel = bankiBevétel;
            this.bankiKiadás = bankiKiadás;
            this.pénztáriBevétel = pénztáriBevétel;
            this.pénztáriKiadás = pénztáriKiadás;

            bankiEgyenleg = bankiEgyenleg + bankiBevétel - bankiKiadás;
            pénztáriEgyenleg = pénztáriEgyenleg + pénztáriBevétel - pénztáriKiadás;
        }
    }
}
