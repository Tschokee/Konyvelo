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
        private List<Bejegyzés> LoadCollectionData()
        {
            List<Bejegyzés> bejegyzések = new List<Bejegyzés>();
            bejegyzések.Add(new Bejegyzés());
            bejegyzések.Add(new Bejegyzés(1, "tegnap", "asdfashdl", new KöltségvetésiCím(), 1000, 300, 500, 600));
            bejegyzések.Add(new Bejegyzés(1, "tegnap", "asdfashdl", new KöltségvetésiCím(), 1000, 300, 500, 600));
            return bejegyzések;
        } 

        public MainWindow()
        {
            InitializeComponent();
            MyDataGrid.ItemsSource = LoadCollectionData();
        }
    }
}
