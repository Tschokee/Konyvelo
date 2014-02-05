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
    /// Interaction logic for KoltsegvetesWindow.xaml
    /// </summary>
    public partial class KoltsegvetesWindow : Window
    {

        public void frissit()
        {
            osszegez(ILista, Iossz);
            osszegez(IILista, IIossz);
            osszegez(IIILista, IIIossz);
            osszegez(IVLista, IVossz);
            evesSajatBevetelNev.Content = "Az egyházközség " + System.DateTime.Now.Year + ". évi saját bevételei összesen:";
            evesSajatBevetelErtek.Content = Convert.ToInt32(Iossz.Content) + Convert.ToInt32(IIossz.Content) + Convert.ToInt32(IIIossz.Content) + Convert.ToInt32(IVossz.Content);
            osszegez(VLista, Vossz);
            evesBevetelNev.Content = "Az egyházközség " + System.DateTime.Now.Year + ". évi bevételei összesen:";
            EvesBevetelErtek.Content = Convert.ToInt32(evesSajatBevetelErtek.Content) + Convert.ToInt32(Vossz.Content);
            osszegez(XIAaLista, XIAaossz);
            osszegez(XIAbLista, XIAbossz);
            XI_Aosszes.Content = Convert.ToInt32(XIAaossz.Content) + Convert.ToInt32(XIAbossz.Content);
            osszegez(XIBaLista, XIBaossz);
            osszegez(XIBbLista, XIBbossz);
            XI_Bosszes.Content = Convert.ToInt32(XIBaossz.Content) + Convert.ToInt32(XIBbossz.Content);
            XIosszes.Content = Convert.ToInt32(XI_Aosszes.Content) + Convert.ToInt32(XI_Bosszes.Content);
            osszegez(XIILista, XIIossz);
            osszegez(XIIILista, XIIIossz);
            osszegez(XIVLista, XIVossz);
            osszegez(XVLista, XVossz);
            osszegez(XVILista, XVIossz);
            osszegez(XVIILista, XVIIossz);
            evesSajatKiadasNev.Content = "Az egyházközség " + System.DateTime.Now.Year + ". évi saját kiadásai összesen:";
            evesSajatKiadasErtek.Content = Convert.ToInt32(XIosszes.Content) + Convert.ToInt32(XIIossz.Content) + Convert.ToInt32(XIIossz.Content) + Convert.ToInt32(XIVossz.Content) + Convert.ToInt32(XVossz.Content) + Convert.ToInt32(XVIossz.Content) + Convert.ToInt32(XVIossz.Content) + Convert.ToInt32(XVIIossz.Content);
            evesKiadasNev.Content = "Az egyházközség " + System.DateTime.Now.Year + ". évi kiadásai összesen:";
            osszegez(XVIIILista, XVIIIossz);
            evesKiadasErtek.Content = Convert.ToInt32(evesSajatKiadasErtek.Content) + Convert.ToInt32(XVIIIossz.Content);
            osszesEloiranyzottEvesBevetelNev.Content = "Összes előirányzott bevétel a " + System.DateTime.Now.Year + ". évre:";
            osszesEloiranyzottEvesBevetelErtek.Content = EvesBevetelErtek.Content;
            osszesEloiranyzottEvesKiadasNev.Content = "Összes előirányzott kiadás a " + System.DateTime.Now.Year + ". évre:";
            osszesEloiranyzottEvesKiadasErtek.Content = evesKiadasErtek.Content;
            kulonbozet.Content = Convert.ToInt32(osszesEloiranyzottEvesBevetelErtek.Content) - Convert.ToInt32(osszesEloiranyzottEvesKiadasErtek.Content);
        }

        public void osszegez(List<PénzMozgás> Lista, Label lab)
        {
            int i = 0;
            foreach (PénzMozgás p in Lista)
            {
                i += p.előirányzat;
            }
            lab.Content = i;
        }

        List<PénzMozgás> ILista, IILista, IIILista, IVLista, VLista, XIAaLista, XIAbLista, XIBaLista, XIBbLista, XIILista, XIIILista, XIVLista, XVLista, XVILista, XVIILista, XVIIILista;
        

        public KoltsegvetesWindow(List<PénzMozgás> ILista, List<PénzMozgás> IILista, List<PénzMozgás> IIILista, List<PénzMozgás> IVLista, List<PénzMozgás> VLista, List<PénzMozgás> XIAaLista, List<PénzMozgás> XIAbLista, List<PénzMozgás> XIBaLista, List<PénzMozgás> XIBbLista, List<PénzMozgás> XIILista, List<PénzMozgás> XIIILista, List<PénzMozgás> XIVLista, List<PénzMozgás> XVLista, List<PénzMozgás> XVILista, List<PénzMozgás> XVIILista, List<PénzMozgás> XVIIILista)
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
            this.ILista = ILista;
            this.IILista = IILista;
            this.IIILista = IIILista;
            this.IVLista = IVLista;
            this.VLista = VLista;
            this.XIAaLista = XIAaLista;
            this.XIAbLista = XIAbLista;
            this.XIBaLista = XIBaLista;
            this.XIBbLista = XIBbLista;
            this.XIILista = XIILista;
            this.XIIILista = XIIILista;
            this.XIVLista = XIVLista;
            this.XVLista = XVLista;
            this.XVILista = XVILista;
            this.XVIILista = XVIILista;
            this.XVIIILista = XVIIILista;
            frissit();
            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right / 2) - (this.Width / 2);
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom / 2) - (this.Height / 2);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            this.ILista = (List<PénzMozgás>)IDataGrid.ItemsSource;
            this.IILista = (List<PénzMozgás>)IIDataGrid.ItemsSource;
            this.IIILista = (List<PénzMozgás>)IIIDataGrid.ItemsSource;
            this.IVLista = (List<PénzMozgás>)IVDataGrid.ItemsSource;
            this.VLista = (List<PénzMozgás>)VDataGrid.ItemsSource;
            this.XIAaLista = (List<PénzMozgás>)XIAaDataGrid.ItemsSource;
            this.XIAbLista = (List<PénzMozgás>)XIAbDataGrid.ItemsSource;
            this.XIBaLista = (List<PénzMozgás>)XIBaDataGrid.ItemsSource;
            this.XIBbLista = (List<PénzMozgás>)XIBbDataGrid.ItemsSource;
            this.XIILista = (List<PénzMozgás>)XIIDataGrid.ItemsSource;
            this.XIIILista = (List<PénzMozgás>)XIIIDataGrid.ItemsSource;
            this.XIVLista = (List<PénzMozgás>)XIVDataGrid.ItemsSource;
            this.XVLista = (List<PénzMozgás>)XVDataGrid.ItemsSource;
            this.XVILista = (List<PénzMozgás>)XVIDataGrid.ItemsSource;
            this.XVIILista = (List<PénzMozgás>)XVIIDataGrid.ItemsSource;
            this.XVIIILista = (List<PénzMozgás>)XVIIIDataGrid.ItemsSource;
            frissit();
        }

        private void megseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
