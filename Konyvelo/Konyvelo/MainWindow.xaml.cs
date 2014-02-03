﻿using System;
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
using System.IO;

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
            bejegyzések.Add(new Bejegyzés(1, "tegnap", "asdfashdl", new PénzMozgás(), 1000, 300, 500, 600));
            bejegyzések.Add(new Bejegyzés(2, "tegnap", "asdfashdl", new PénzMozgás(), 1000, 300, 500, 600));
            bejegyzések.Add(new Bejegyzés(3, "tegnap", "asdfashdl", new PénzMozgás(), 200, 600, 1200, 100));
            return bejegyzések;
        }

        private void openFile()
        {
            TextReader sr = new StreamReader("entries.txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }

        public MainWindow()
        {
            openFile();
            InitializeComponent();
            LoadCollectionData();
            MyDataGrid.ItemsSource = bejegyzések/*LoadCollectionData()*/;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Window NLW = new NewLineWindow(bejegyzések, MyDataGrid);
            //NLW.Show();
            Window cw = new ChoiceWindow(bejegyzések, MyDataGrid);
            cw.Show();
        }

        private void modositButton_Click(object sender, RoutedEventArgs e)
        {
            int t = Convert.ToInt32(MyDataGrid.SelectedIndex.ToString());
            if (bejegyzések.Count() != 0 && t != -1 && t <= bejegyzések.Count() - 1)
            {
                Window MW = new ModifyWindow(bejegyzések, MyDataGrid, t);
                MW.Show();
            }
        }

        private void torolButton_Click(object sender, RoutedEventArgs e)
        {
            int t = Convert.ToInt32(MyDataGrid.SelectedIndex.ToString());
            if (t < bejegyzések.Count() && t > -1)
            {
                bejegyzések.RemoveAt(t);
                Bejegyzés.globalBankiEgyenleg = 0;
                Bejegyzés.globalPenztariEgyenleg = 0;
                foreach (Bejegyzés b in bejegyzések)
                {
                    b.modositGlobalEgyenleg();
                }
            }

            MyDataGrid.Items.Refresh();
        }

    }
}
