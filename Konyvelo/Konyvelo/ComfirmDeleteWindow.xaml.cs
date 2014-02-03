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
    /// Interaction logic for ComfirmDeleteWindow.xaml
    /// </summary>
    public partial class ComfirmDeleteWindow : Window
    {
        public List<Bejegyzés> bejegyzések;
        public DataGrid MyDataGrid;
        public ComfirmDeleteWindow(List<Bejegyzés> l, DataGrid d)
        {
            InitializeComponent();
            this.bejegyzések = l;
            this.MyDataGrid = d;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int t = Convert.ToInt32(MyDataGrid.SelectedIndex.ToString());
            if (t < bejegyzések.Count() && t > -1)
            {
                int ssz = bejegyzések.ElementAt(t).sorSzám;
                int i = 1, j = ssz;
                bejegyzések.RemoveAt(t);
                Bejegyzés.globalBankiEgyenleg = 0;
                Bejegyzés.globalPenztariEgyenleg = 0;
                foreach (Bejegyzés b in bejegyzések)
                {
                    b.modositGlobalEgyenleg();
                    if (i >= ssz)
                    {
                        b.sorSzám = j;
                        j++;
                    }
                    i++;
                }
            }

            MyDataGrid.Items.Refresh();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
