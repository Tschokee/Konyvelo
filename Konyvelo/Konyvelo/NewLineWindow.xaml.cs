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
        int s;

        public NewLineWindow(List<Bejegyzés> l, DataGrid d, int s)
        {
            InitializeComponent();
            this.list = l;
            this.d = d;
            this.s = s;
            switch (s)
            {
                case 1 : changeLabel.Content = "Banki bevétel"; break;
                case 2 : changeLabel.Content = "Banki kiadás"; break;
                case 3: changeLabel.Content = "Pénztári bevétel"; break;
                case 4: changeLabel.Content = "Pénztári kiadás"; break;
                default: break;
            }
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
            int ssz = 0;
            if (list.Count != 0)
                ssz = list.Last().sorSzám;

            int k = 0;

            if (changeBox.Text.Length != 0) k = Convert.ToInt32(changeBox.Text);

            switch (s)
            {
                case 1: list.Add(new Bejegyzés(ssz + 1, fizetesBox.Text, meghegyzesBox.Text, new PénzMozgás(), k, 0, 0, 0)); break;
                case 2: list.Add(new Bejegyzés(ssz + 1, fizetesBox.Text, meghegyzesBox.Text, new PénzMozgás(), 0, k, 0, 0)); break;
                case 3: list.Add(new Bejegyzés(ssz + 1, fizetesBox.Text, meghegyzesBox.Text, new PénzMozgás(), 0, 0, k, 0)); break;
                case 4: list.Add(new Bejegyzés(ssz + 1, fizetesBox.Text, meghegyzesBox.Text, new PénzMozgás(), 0, 0, 0, k)); break;
                default: break;
            }

            d.Items.Refresh();
            
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
