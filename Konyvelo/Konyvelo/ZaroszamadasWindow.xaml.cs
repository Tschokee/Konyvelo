using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Konyvelo
{
    /// <summary>
    /// Interaction logic for ZaroszamadasWindow.xaml
    /// </summary>
    public partial class ZaroszamadasWindow : Window
    {

        public void osszegezElo(List<PénzMozgás> Lista, Label lab)
        {
            int i = 0;
            foreach (PénzMozgás p in Lista)
            {
                i += p.előirányzat;
            }
            lab.Content = i;
        }

        public void osszegezTelj(List<PénzMozgás> Lista, Label lab)
        {
            int i = 0;
            foreach (PénzMozgás p in Lista)
            {
                i += p.teljesítés;
            }
            lab.Content = i;
        }

        public void nullaz(PénzMozgás p)
        {
            p.teljesítés = 0;
        }

        public ZaroszamadasWindow(List<Bejegyzés> bl,List<PénzMozgás> ILista, List<PénzMozgás> IILista, List<PénzMozgás> IIILista,
            List<PénzMozgás> IVLista, List<PénzMozgás> VLista, List<PénzMozgás> XIAaLista, List<PénzMozgás> XIAbLista,
            List<PénzMozgás> XIBaLista, List<PénzMozgás> XIBbLista, List<PénzMozgás> XIILista, List<PénzMozgás> XIIILista,
            List<PénzMozgás> XIVLista, List<PénzMozgás> XVLista, List<PénzMozgás> XVILista, List<PénzMozgás> XVIILista,
            List<PénzMozgás> XVIIILista)
        {
            InitializeComponent();
            IDataGrid.ItemsSource = ILista;
            IIDataGrid.ItemsSource = IILista;
            IIIDataGrid.ItemsSource = IIILista;
            IVDataGrid.ItemsSource = IVLista;
            VDataGrid.ItemsSource = VLista;
            XIAaDataGrid.ItemsSource = XIAaLista;
            XIAbDataGrid.ItemsSource = XIAbLista;
            XIBaDataGrid.ItemsSource = XIBaLista;
            XIBbDataGrid.ItemsSource = XIBbLista;
            XIIDataGrid.ItemsSource = XIILista;
            XIIIDataGrid.ItemsSource = XIIILista;
            XIVDataGrid.ItemsSource = XIVLista;
            XVDataGrid.ItemsSource = XVLista;
            XVIDataGrid.ItemsSource = XVILista;
            XVIIDataGrid.ItemsSource = XVIILista;
            XVIIIDataGrid.ItemsSource = XVIIILista;
            osszegezElo(IILista, IIelo);
            osszegezElo(IIILista, IIIelo);
            osszegezElo(IVLista, IVelo);
            evesSajatBevetelNev.Content = "Az egyházközség " + System.DateTime.Now.Year + ". évi saját bevételei összesen:";
            evesSajatBevetelelo.Content = ILista[0].előirányzat + Convert.ToInt32(IIelo.Content) + Convert.ToInt32(IIIelo.Content) + Convert.ToInt32(IVelo.Content);
            osszegezElo(VLista, Velo);
            evesBevetelNev.Content = "Az egyházközség " + System.DateTime.Now.Year + ". évi bevételei összesen:";
            EvesBevetelelo.Content = Convert.ToInt32(evesSajatBevetelelo.Content) + Convert.ToInt32(Velo.Content);
            osszegezElo(XIAaLista, XIAaelo);
            osszegezElo(XIAbLista, XIAbelo);
            XI_Aelo.Content = Convert.ToInt32(XIAaelo.Content) + Convert.ToInt32(XIAbelo.Content);
            osszegezElo(XIBaLista, XIBaelo);
            osszegezElo(XIBbLista, XIBbelo);
            XI_Belo.Content = Convert.ToInt32(XIBaelo.Content) + Convert.ToInt32(XIBbelo.Content);
            XIelo.Content = Convert.ToInt32(XI_Aelo.Content) + Convert.ToInt32(XI_Belo.Content);
            osszegezElo(XIILista, XIIelo);
            osszegezElo(XIIILista, XIIIelo);
            osszegezElo(XIVLista, XIVelo);
            osszegezElo(XVLista, XVelo);
            osszegezElo(XVILista, XVIelo);
            osszegezElo(XVIILista, XVIIelo);
            evesSajatKiadasNev.Content = "Az egyházközség " + System.DateTime.Now.Year + ". évi saját kiadásai összesen:";
            evesSajatKiadaselo.Content = Convert.ToInt32(XIelo.Content) + Convert.ToInt32(XIIelo.Content) + Convert.ToInt32(XIIelo.Content) + Convert.ToInt32(XIVelo.Content) + Convert.ToInt32(XVelo.Content) + Convert.ToInt32(XVIelo.Content) + Convert.ToInt32(XVIelo.Content) + Convert.ToInt32(XVIIelo.Content);
            evesKiadasNev.Content = "Az egyházközség " + System.DateTime.Now.Year + ". évi kiadásai összesen:";
            osszegezElo(XVIIILista, XVIIIelo);
            evesKiadaselo.Content = Convert.ToInt32(evesSajatKiadaselo.Content) + Convert.ToInt32(XVIIIelo.Content);
            osszesEloiranyzottEvesBevetelNev.Content = "Összes előirányzott bevétel a " + System.DateTime.Now.Year + ". évre:";
            osszesEloiranyzottEvesBevetelelo.Content = EvesBevetelelo.Content;
            osszesEloiranyzottEvesKiadasNev.Content = "Összes előirányzott kiadás a " + System.DateTime.Now.Year + ". évre:";
            osszesEloiranyzottEvesKiadaselo.Content = evesKiadaselo.Content;
            kulonbozetelo.Content = Convert.ToInt32(osszesEloiranyzottEvesBevetelelo.Content) - Convert.ToInt32(osszesEloiranyzottEvesKiadaselo.Content);

            ILista.ForEach(nullaz);
            IILista.ForEach(nullaz);
            IIILista.ForEach(nullaz);
            IVLista.ForEach(nullaz);
            VLista.ForEach(nullaz);
            XIAaLista.ForEach(nullaz);
            XIAbLista.ForEach(nullaz);
            XIBaLista.ForEach(nullaz);
            XIBbLista.ForEach(nullaz);
            XIILista.ForEach(nullaz);
            XIIILista.ForEach(nullaz);
            XIVLista.ForEach(nullaz);
            XVLista.ForEach(nullaz);
            XVILista.ForEach(nullaz);
            XVIILista.ForEach(nullaz);
            XVIIILista.ForEach(nullaz);

            foreach (Bejegyzés b in bl)
            {
                if (b.főkönyv.Equals(ILista[0].azonosító))
                {
                    ILista[0].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IILista[0].azonosító))
                {
                    IILista[0].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IILista[1].azonosító))
                {
                    IILista[1].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IILista[2].azonosító))
                {
                    IILista[2].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IILista[3].azonosító))
                {
                    IILista[3].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IILista[4].azonosító))
                {
                    IILista[4].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IILista[5].azonosító))
                {
                    IILista[5].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IIILista[0].azonosító))
                {
                    IIILista[0].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IIILista[1].azonosító))
                {
                    IIILista[1].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IIILista[2].azonosító))
                {
                    IIILista[2].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IIILista[3].azonosító))
                {
                    IIILista[3].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IIILista[4].azonosító))
                {
                    IIILista[4].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IIILista[5].azonosító))
                {
                    IIILista[5].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IIILista[6].azonosító))
                {
                    IIILista[6].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IIILista[7].azonosító))
                {
                    IIILista[7].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IIILista[8].azonosító))
                {
                    IIILista[8].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IIILista[9].azonosító))
                {
                    IIILista[9].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IVLista[0].azonosító))
                {
                    IVLista[0].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IVLista[1].azonosító))
                {
                    IVLista[1].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IVLista[2].azonosító))
                {
                    IVLista[2].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IVLista[3].azonosító))
                {
                    IVLista[3].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IVLista[4].azonosító))
                {
                    IVLista[4].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IVLista[5].azonosító))
                {
                    IVLista[5].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IVLista[6].azonosító))
                {
                    IVLista[6].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IVLista[7].azonosító))
                {
                    IVLista[7].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IVLista[8].azonosító))
                {
                    IVLista[8].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(IVLista[9].azonosító))
                {
                    IVLista[9].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(VLista[0].azonosító))
                {
                    VLista[0].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(VLista[1].azonosító))
                {
                    VLista[1].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(VLista[2].azonosító))
                {
                    VLista[2].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(VLista[3].azonosító))
                {
                    VLista[3].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(VLista[4].azonosító))
                {
                    VLista[4].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(VLista[5].azonosító))
                {
                    VLista[5].teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                    continue;
                }
                if (b.főkönyv.Equals(XIAaLista[0].azonosító))
                {
                    XIAaLista[0].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIAaLista[1].azonosító))
                {
                    XIAaLista[1].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIAaLista[2].azonosító))
                {
                    XIAaLista[2].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIAaLista[3].azonosító))
                {
                    XIAaLista[3].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIAaLista[4].azonosító))
                {
                    XIAaLista[4].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIAaLista[5].azonosító))
                {
                    XIAaLista[5].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIAaLista[6].azonosító))
                {
                    XIAaLista[6].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIAaLista[7].azonosító))
                {
                    XIAaLista[7].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIAaLista[8].azonosító))
                {
                    XIAaLista[8].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIAaLista[9].azonosító))
                {
                    XIAaLista[9].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIAaLista[10].azonosító))
                {
                    XIAaLista[10].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIAaLista[11].azonosító))
                {
                    XIAaLista[11].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIAaLista[12].azonosító))
                {
                    XIAaLista[12].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIAaLista[13].azonosító))
                {
                    XIAaLista[13].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIAbLista[0].azonosító))
                {
                    XIAbLista[0].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIAbLista[1].azonosító))
                {
                    XIAbLista[1].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIAbLista[2].azonosító))
                {
                    XIAbLista[2].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIBaLista[0].azonosító))
                {
                    XIBaLista[0].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIBaLista[1].azonosító))
                {
                    XIBaLista[1].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIBaLista[2].azonosító))
                {
                    XIBaLista[2].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIBaLista[3].azonosító))
                {
                    XIBaLista[3].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIBaLista[4].azonosító))
                {
                    XIBaLista[4].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIBaLista[5].azonosító))
                {
                    XIBaLista[5].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIBaLista[6].azonosító))
                {
                    XIBaLista[6].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIBaLista[7].azonosító))
                {
                    XIBaLista[7].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIBaLista[8].azonosító))
                {
                    XIBaLista[8].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIBaLista[9].azonosító))
                {
                    XIBaLista[9].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIBbLista[0].azonosító))
                {
                    XIBbLista[0].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIBbLista[1].azonosító))
                {
                    XIBbLista[1].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIBbLista[2].azonosító))
                {
                    XIBbLista[2].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIILista[0].azonosító))
                {
                    XIILista[0].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIILista[1].azonosító))
                {
                    XIILista[1].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIILista[2].azonosító))
                {
                    XIILista[2].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIILista[3].azonosító))
                {
                    XIILista[3].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIILista[4].azonosító))
                {
                    XIILista[4].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIILista[5].azonosító))
                {
                    XIILista[5].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIILista[6].azonosító))
                {
                    XIILista[6].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIILista[7].azonosító))
                {
                    XIILista[7].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIILista[8].azonosító))
                {
                    XIILista[8].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIILista[9].azonosító))
                {
                    XIILista[9].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIILista[10].azonosító))
                {
                    XIILista[10].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIILista[11].azonosító))
                {
                    XIILista[11].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIILista[12].azonosító))
                {
                    XIILista[12].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIILista[13].azonosító))
                {
                    XIILista[13].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIIILista[0].azonosító))
                {
                    XIIILista[0].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIIILista[1].azonosító))
                {
                    XIIILista[1].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIIILista[2].azonosító))
                {
                    XIIILista[2].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIIILista[3].azonosító))
                {
                    XIIILista[3].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIIILista[4].azonosító))
                {
                    XIIILista[4].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIIILista[5].azonosító))
                {
                    XIIILista[5].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIIILista[6].azonosító))
                {
                    XIIILista[6].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIIILista[7].azonosító))
                {
                    XIIILista[7].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIIILista[8].azonosító))
                {
                    XIIILista[8].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIIILista[9].azonosító))
                {
                    XIIILista[9].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIIILista[10].azonosító))
                {
                    XIIILista[10].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIIILista[11].azonosító))
                {
                    XIIILista[11].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIIILista[12].azonosító))
                {
                    XIIILista[12].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIIILista[13].azonosító))
                {
                    XIIILista[13].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIIILista[14].azonosító))
                {
                    XIIILista[14].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIVLista[0].azonosító))
                {
                    XIVLista[0].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIVLista[1].azonosító))
                {
                    XIVLista[1].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIVLista[2].azonosító))
                {
                    XIVLista[2].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIVLista[3].azonosító))
                {
                    XIVLista[3].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIVLista[4].azonosító))
                {
                    XIVLista[4].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIVLista[5].azonosító))
                {
                    XIVLista[5].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIVLista[6].azonosító))
                {
                    XIVLista[6].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIVLista[7].azonosító))
                {
                    XIVLista[7].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIVLista[8].azonosító))
                {
                    XIVLista[8].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIVLista[9].azonosító))
                {
                    XIVLista[9].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIVLista[10].azonosító))
                {
                    XIVLista[10].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIVLista[11].azonosító))
                {
                    XIVLista[11].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIVLista[12].azonosító))
                {
                    XIVLista[12].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XIVLista[13].azonosító))
                {
                    XIVLista[13].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVLista[0].azonosító))
                {
                    XVLista[0].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVLista[1].azonosító))
                {
                    XVLista[1].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVLista[2].azonosító))
                {
                    XVLista[2].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVLista[3].azonosító))
                {
                    XVLista[3].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVLista[4].azonosító))
                {
                    XVLista[4].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVLista[5].azonosító))
                {
                    XVLista[5].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVLista[6].azonosító))
                {
                    XVLista[6].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVILista[0].azonosító))
                {
                    XIVLista[0].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVIILista[0].azonosító))
                {
                    XVIILista[0].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVIILista[1].azonosító))
                {
                    XVIILista[1].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVIILista[2].azonosító))
                {
                    XVIILista[2].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVIILista[3].azonosító))
                {
                    XVIILista[3].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVIILista[4].azonosító))
                {
                    XVIILista[4].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVIILista[5].azonosító))
                {
                    XVIILista[5].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVIIILista[0].azonosító))
                {
                    XVIIILista[0].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVIIILista[1].azonosító))
                {
                    XVIIILista[1].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVIIILista[2].azonosító))
                {
                    XVIIILista[2].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVIIILista[3].azonosító))
                {
                    XVIIILista[3].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVIIILista[4].azonosító))
                {
                    XVIIILista[4].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }
                if (b.főkönyv.Equals(XVIIILista[5].azonosító))
                {
                    XVIIILista[5].teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                    continue;
                }              
            }

            osszegezTelj(IILista, IItelj);
            osszegezTelj(IIILista, IIItelj);
            osszegezTelj(IVLista, IVtelj);
            osszegezTelj(VLista, Vtelj);
            osszegezTelj(XIAaLista, XIAatelj);
            osszegezTelj(XIAbLista, XIAbtelj);
            osszegezTelj(XIBaLista, XIBatelj);
            osszegezTelj(XIBbLista, XIBbtelj);
            osszegezTelj(XIILista, XIItelj);
            osszegezTelj(XIIILista, XIIItelj);
            osszegezTelj(XIVLista, XIVtelj);
            osszegezTelj(XVLista, XVtelj);
            osszegezTelj(XVILista, XVItelj);
            osszegezTelj(XVIILista, XVIItelj);
            osszegezTelj(XVIIILista, XVIIItelj);

            evesSajatBeveteltelj.Content = ILista[0].teljesítés + Convert.ToInt32(IItelj.Content) + Convert.ToInt32(IIItelj.Content) + Convert.ToInt32(IVtelj.Content);
            EvesBeveteltelj.Content = Convert.ToInt32(evesSajatBeveteltelj.Content) + Convert.ToInt32(Vtelj.Content);
            XI_Atelj.Content = Convert.ToInt32(XIAatelj.Content) + Convert.ToInt32(XIAbtelj.Content);
            XI_Btelj.Content = Convert.ToInt32(XIBatelj.Content) + Convert.ToInt32(XIBbtelj.Content);
            XItelj.Content = Convert.ToInt32(XI_Atelj.Content) + Convert.ToInt32(XI_Btelj.Content);
            evesSajatKiadastelj.Content = Convert.ToInt32(XItelj.Content) + Convert.ToInt32(XIItelj.Content) + Convert.ToInt32(XIItelj.Content) + Convert.ToInt32(XIVtelj.Content) + Convert.ToInt32(XVtelj.Content) + Convert.ToInt32(XVItelj.Content) + Convert.ToInt32(XVItelj.Content) + Convert.ToInt32(XVIItelj.Content);
            evesKiadastelj.Content = Convert.ToInt32(evesSajatKiadastelj.Content) + Convert.ToInt32(XVIIItelj.Content);
            osszesEloiranyzottEvesBeveteltelj.Content = EvesBeveteltelj.Content;
            osszesEloiranyzottEvesKiadastelj.Content = evesKiadastelj.Content;
            kulonbozettelj.Content = Convert.ToInt32(osszesEloiranyzottEvesBeveteltelj.Content) - Convert.ToInt32(osszesEloiranyzottEvesKiadastelj.Content);

            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right / 2) - (this.Width / 2);
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom / 2) - (this.Height / 2);
        }
    }
}
