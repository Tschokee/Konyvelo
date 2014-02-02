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
    /// Interaction logic for ModifyWindow.xaml
    /// </summary>
    public partial class ModifyWindow : Window
    {
        public List<Bejegyzés> list;
        public DataGrid d;
        public int t;

        public ModifyWindow(List<Bejegyzés> l, DataGrid d, int t)
        {
            InitializeComponent();
            this.list = l;
            this.d = d;
            this.t = t;
            fizetesBox.Text = l.ElementAt(t).fizetésIdeje;
            meghegyzesBox.Text = l.ElementAt(t).megjegyzés;
            bankiBeviletBox.Text = l.ElementAt(t).bankiBevétel.ToString();
            bankiKiadasBox.Text = l.ElementAt(t).bankiKiadás.ToString();
            penztariBevetelBox.Text = l.ElementAt(t).pénztáriBevétel.ToString();
            penztariKiadasBox.Text = l.ElementAt(t).pénztáriKiadás.ToString();

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

            list.ElementAt(t).fizetésIdeje = fizetesBox.Text;
            list.ElementAt(t).megjegyzés = meghegyzesBox.Text;
            list.ElementAt(t).bankiBevétel = bb;
            list.ElementAt(t).bankiKiadás = bk;
            list.ElementAt(t).pénztáriBevétel = pb;
            list.ElementAt(t).pénztáriKiadás = pk;

            Bejegyzés.globalBankiEgyenleg = 0;
            Bejegyzés.globalPenztariEgyenleg = 0;
            foreach (Bejegyzés b in list)
            {
                b.modositGlobalEgyenleg();
            }
            //global banki és pénztári egyenleg újraszámolása a módosítottól szükséges

            d.Items.Refresh();

            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
