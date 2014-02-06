using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvelo
{
    public class Bejegyzés
    {
        public static int globalBankiEgyenleg { get; set; }
        public static int globalPenztariEgyenleg { get; set; }

        public int sorSzám { get; set; }
        public string fizetésIdeje { get; set; }
        public string megjegyzés { get; set; }
        public string főkönyv { get; set; }
        public int bankiBevétel { get; set; }
        public int bankiKiadás { get; set; }
        public int bankiEgyenleg { get; set; } 
        public int pénztáriBevétel { get; set; }
        public int pénztáriKiadás { get; set; }
        public int pénztáriEgyenleg { get; set; }
        public int osszBevetel { get; set; }
        public int osszKiadas { get; set; }

        public Bejegyzés()
        {
            this.sorSzám = 0;
            this.fizetésIdeje = "ma";
            this.megjegyzés = "note";
            this.főkönyv = "TEMP";
            this.bankiBevétel = 300;
            this.bankiKiadás = 300;
            this.pénztáriBevétel = 300;
            this.pénztáriKiadás = 300;
            Bejegyzés.globalBankiEgyenleg += (bankiBevétel - bankiKiadás);
            Bejegyzés.globalPenztariEgyenleg += (pénztáriBevétel - pénztáriKiadás);

            bankiEgyenleg = globalBankiEgyenleg;
            pénztáriEgyenleg = globalPenztariEgyenleg;
        }

        public Bejegyzés(int sorSzám, string fizetésIdeje, string megjegyzés, string főkönyv, int bankiBevétel, int bankiKiadás, int pénztáriBevétel, int pénztáriKiadás)
        {
            this.sorSzám = sorSzám;
            this.fizetésIdeje = fizetésIdeje;
            this.megjegyzés = megjegyzés;
            this.főkönyv = főkönyv;
            this.bankiBevétel = bankiBevétel;
            this.bankiKiadás = bankiKiadás;
            this.pénztáriBevétel = pénztáriBevétel;
            this.pénztáriKiadás = pénztáriKiadás;
            this.osszBevetel = bankiBevétel + pénztáriBevétel;
            this.osszKiadas = bankiKiadás + pénztáriKiadás;
            Bejegyzés.globalBankiEgyenleg += (bankiBevétel - bankiKiadás);
            Bejegyzés.globalPenztariEgyenleg += (pénztáriBevétel - pénztáriKiadás);

            bankiEgyenleg = globalBankiEgyenleg;
            pénztáriEgyenleg = globalPenztariEgyenleg;
        }

        public void modositGlobalEgyenleg()
        {
           
           Bejegyzés.globalBankiEgyenleg += (bankiBevétel - bankiKiadás);
           Bejegyzés.globalPenztariEgyenleg += (pénztáriBevétel - pénztáriKiadás);

           bankiEgyenleg = globalBankiEgyenleg;
           pénztáriEgyenleg = globalPenztariEgyenleg;
           
        }
    }
}
