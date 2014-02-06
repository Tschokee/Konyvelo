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

        public void osszegez(List<PénzMozgás> Lista, Label lab)
        {
            int i = 0;
            foreach (PénzMozgás p in Lista)
            {
                i += p.előirányzat;
            }
            lab.Content = i;
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
            osszegez(IILista, IIelo);
            osszegez(IIILista, IIIelo);
            osszegez(IVLista, IVelo);
            evesSajatBevetelNev.Content = "Az egyházközség " + System.DateTime.Now.Year + ". évi saját bevételei összesen:";
            evesSajatBevetelelo.Content = ILista[0].előirányzat + Convert.ToInt32(IIelo.Content) + Convert.ToInt32(IIIelo.Content) + Convert.ToInt32(IVelo.Content);
            osszegez(VLista, Velo);
            evesBevetelNev.Content = "Az egyházközség " + System.DateTime.Now.Year + ". évi bevételei összesen:";
            EvesBevetelelo.Content = Convert.ToInt32(evesSajatBevetelelo.Content) + Convert.ToInt32(Velo.Content);
            osszegez(XIAaLista, XIAaelo);
            osszegez(XIAbLista, XIAbelo);
            XI_Aelo.Content = Convert.ToInt32(XIAaelo.Content) + Convert.ToInt32(XIAbelo.Content);
            osszegez(XIBaLista, XIBaelo);
            osszegez(XIBbLista, XIBbelo);
            XI_Belo.Content = Convert.ToInt32(XIBaelo.Content) + Convert.ToInt32(XIBbelo.Content);
            XIelo.Content = Convert.ToInt32(XI_Aelo.Content) + Convert.ToInt32(XI_Belo.Content);
            osszegez(XIILista, XIIelo);
            osszegez(XIIILista, XIIIelo);
            osszegez(XIVLista, XIVelo);
            osszegez(XVLista, XVelo);
            osszegez(XVILista, XVIelo);
            osszegez(XVIILista, XVIIelo);
            evesSajatKiadasNev.Content = "Az egyházközség " + System.DateTime.Now.Year + ". évi saját kiadásai összesen:";
            evesSajatKiadaselo.Content = Convert.ToInt32(XIelo.Content) + Convert.ToInt32(XIIelo.Content) + Convert.ToInt32(XIIelo.Content) + Convert.ToInt32(XIVelo.Content) + Convert.ToInt32(XVelo.Content) + Convert.ToInt32(XVIelo.Content) + Convert.ToInt32(XVIelo.Content) + Convert.ToInt32(XVIIelo.Content);
            evesKiadasNev.Content = "Az egyházközség " + System.DateTime.Now.Year + ". évi kiadásai összesen:";
            osszegez(XVIIILista, XVIIIelo);
            evesKiadaselo.Content = Convert.ToInt32(evesSajatKiadaselo.Content) + Convert.ToInt32(XVIIIelo.Content);
            osszesEloiranyzottEvesBevetelNev.Content = "Összes előirányzott bevétel a " + System.DateTime.Now.Year + ". évre:";
            osszesEloiranyzottEvesBevetelelo.Content = EvesBevetelelo.Content;
            osszesEloiranyzottEvesKiadasNev.Content = "Összes előirányzott kiadás a " + System.DateTime.Now.Year + ". évre:";
            osszesEloiranyzottEvesKiadaselo.Content = evesKiadaselo.Content;
            kulonbozetelo.Content = Convert.ToInt32(osszesEloiranyzottEvesBevetelelo.Content) - Convert.ToInt32(osszesEloiranyzottEvesKiadaselo.Content);


            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right / 2) - (this.Width / 2);
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom / 2) - (this.Height / 2);
        }
    }
}
