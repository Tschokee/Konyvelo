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
    /// Interaction logic for NewLineWindow.xaml
    /// </summary>
    public partial class NewLineWindow : Window
    {
        public List<Bejegyzés> list;
        public DataGrid d;

        public NewLineWindow(List<Bejegyzés> l, DataGrid d)
        {
            InitializeComponent();
            this.list = l;
            this.d = d;
            fokonyvComboBox.Items.Add("I");
            fokonyvComboBox.Items.Add("II");
            fokonyvComboBox.Items.Add("III");
            fokonyvComboBox.Items.Add("III");
            fokonyvComboBox.Items.Add("III");
            fokonyvComboBox.Items.Add("III");
            fokonyvComboBox.Items.Add("III");
            fokonyvComboBox.Items.Add("III");
            fokonyvComboBox.Items.Add("III");
            fokonyvComboBox.Items.Add("III");
            fokonyvComboBox.Items.Add("III");
            fokonyvComboBox.Items.Add("III");
            fokonyvComboBox.Items.Add("III");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int s = 0;
            if (list.Count != 0)
                s = list.Last().sorSzám;

            //Ha üres string, akkor 0-t ír be
            int bb, bk, pb, pk;
            if (bankiBeviletBox.Text.Length == 0) bb = 0;
            else bb = Convert.ToInt32(bankiBeviletBox.Text);

            if (bankiKiadasBox.Text.Length == 0) bk = 0;
            else bk = Convert.ToInt32(bankiKiadasBox.Text);

            if (penztariBevetelBox.Text.Length == 0) pb = 0;
            else pb = Convert.ToInt32(penztariBevetelBox.Text);

            if (penztariKiadasBox.Text.Length == 0) pk = 0;
            else pk = Convert.ToInt32(penztariKiadasBox.Text);

            list.Add(new Bejegyzés(s + 1, fizetesBox.Text, meghegyzesBox.Text, new Pénzmozgás(), bb, bk, pb, pk));

            d.Items.Refresh();
            
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
