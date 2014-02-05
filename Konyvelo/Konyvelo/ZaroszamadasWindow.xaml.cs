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
        public ZaroszamadasWindow(List<PénzMozgás> ILista, List<PénzMozgás> IILista, List<PénzMozgás> IIILista,
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
            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right / 2) - (this.Width / 2);
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom / 2) - (this.Height / 2);
        }
    }
}
