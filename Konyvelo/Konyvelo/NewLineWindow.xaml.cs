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
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int s = 0;
            if (list.Count != 0)
                s = list.Last().sorSzám;
            list.Add(new Bejegyzés(s + 1, fizetesBox.Text, meghegyzesBox.Text, new KöltségvetésiCím(), Convert.ToInt32(bannkiBeviletBox.Text), Convert.ToInt32(bankiKiadasBox.Text), Convert.ToInt32(penztariBevetelBox.Text), Convert.ToInt32(penztariKiadasBox.Text)));

            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
