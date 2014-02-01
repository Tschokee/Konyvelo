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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Konyvelo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Bejegyzés> bejegyzések = new List<Bejegyzés>();
        private List<Bejegyzés> LoadCollectionData()
        {
            //List<Bejegyzés> bejegyzések = new List<Bejegyzés>();
            //bejegyzések.Add(new Bejegyzés());
            bejegyzések.Add(new Bejegyzés(1, "tegnap", "asdfashdl", new KöltségvetésiCím(), 1000, 300, 500, 600));
            bejegyzések.Add(new Bejegyzés(2, "tegnap", "asdfashdl", new KöltségvetésiCím(), 1000, 300, 500, 600));
            bejegyzések.Add(new Bejegyzés(3, "tegnap", "asdfashdl", new KöltségvetésiCím(), 200, 600, 1200, 100));
            return bejegyzések;
        }

        public MainWindow()
        {
            InitializeComponent();
            LoadCollectionData();
            MyDataGrid.ItemsSource = bejegyzések/*LoadCollectionData()*/;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window NLW = new NewLineWindow(bejegyzések, MyDataGrid);
            NLW.Show();
        }

    }
}
