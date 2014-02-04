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
        string ss;

        public NewLineWindow(List<Bejegyzés> l, DataGrid d, int s, List<PénzMozgás> ILista, List<PénzMozgás> IILista, List<PénzMozgás> IIILista, List<PénzMozgás> IVLista, List<PénzMozgás> VLista, List<PénzMozgás> XIAaLista, List<PénzMozgás> XIAbLista, List<PénzMozgás> XIBaLista, List<PénzMozgás> XIBbLista)
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
            foreach (PénzMozgás penz in ILista)
            {
                ss = penz.azonosító;
                if (penz.azonosítóMásodikSzint != null)
                {
                    ss = ss + "/" + penz.azonosítóMásodikSzint;
                    if (penz.azonosítóHarmadikSzint != null)
                    {
                        ss = ss + "/" + penz.azonosítóHarmadikSzint;
                        if (penz.azonosítóNegyedikSzint != null)
                            ss = ss + "/" + penz.azonosítóNegyedikSzint;
                    }
                }
                fokonyvComboBox.Items.Add(ss);
            }
            foreach (PénzMozgás penz in IILista)
            {
                ss = penz.azonosító;
                if (penz.azonosítóMásodikSzint != null)
                {
                    ss = ss + "/" + penz.azonosítóMásodikSzint;
                    if (penz.azonosítóHarmadikSzint != null)
                    {
                        ss = ss + "/" + penz.azonosítóHarmadikSzint;
                        if (penz.azonosítóNegyedikSzint != null)
                            ss = ss + "/" + penz.azonosítóNegyedikSzint;
                    }
                }
                fokonyvComboBox.Items.Add(ss);
            }
            foreach (PénzMozgás penz in IIILista)
            {
                ss = penz.azonosító;
                if (penz.azonosítóMásodikSzint != null)
                {
                    ss = ss + "/" + penz.azonosítóMásodikSzint;
                    if (penz.azonosítóHarmadikSzint != null)
                    {
                        ss = ss + "/" + penz.azonosítóHarmadikSzint;
                        if (penz.azonosítóNegyedikSzint != null)
                            ss = ss + "/" + penz.azonosítóNegyedikSzint;
                    }
                }
                fokonyvComboBox.Items.Add(ss);
            }
            foreach (PénzMozgás penz in IVLista)
            {
                ss = penz.azonosító;
                if (penz.azonosítóMásodikSzint != null)
                {
                    ss = ss + "/" + penz.azonosítóMásodikSzint;
                    if (penz.azonosítóHarmadikSzint != null)
                    {
                        ss = ss + "/" + penz.azonosítóHarmadikSzint;
                        if (penz.azonosítóNegyedikSzint != null)
                            ss = ss + "/" + penz.azonosítóNegyedikSzint;
                    }
                }
                fokonyvComboBox.Items.Add(ss);
            }
            foreach (PénzMozgás penz in VLista)
            {
                ss = penz.azonosító;
                if (penz.azonosítóMásodikSzint != null)
                {
                    ss = ss + "/" + penz.azonosítóMásodikSzint;
                    if (penz.azonosítóHarmadikSzint != null)
                    {
                        ss = ss + "/" + penz.azonosítóHarmadikSzint;
                        if (penz.azonosítóNegyedikSzint != null)
                            ss = ss + "/" + penz.azonosítóNegyedikSzint;
                    }
                }
                fokonyvComboBox.Items.Add(ss);
            }
            foreach (PénzMozgás penz in XIAaLista)
            {
                ss = penz.azonosító;
                if (penz.azonosítóMásodikSzint != null)
                {
                    ss = ss + "/" + penz.azonosítóMásodikSzint;
                    if (penz.azonosítóHarmadikSzint != null)
                    {
                        ss = ss + "/" + penz.azonosítóHarmadikSzint;
                        if (penz.azonosítóNegyedikSzint != null)
                            ss = ss + "/" + penz.azonosítóNegyedikSzint;
                    }
                }
                fokonyvComboBox.Items.Add(ss);
            }
            foreach (PénzMozgás penz in XIAbLista)
            {
                ss = penz.azonosító;
                if (penz.azonosítóMásodikSzint != null)
                {
                    ss = ss + "/" + penz.azonosítóMásodikSzint;
                    if (penz.azonosítóHarmadikSzint != null)
                    {
                        ss = ss + "/" + penz.azonosítóHarmadikSzint;
                        if (penz.azonosítóNegyedikSzint != null)
                            ss = ss + "/" + penz.azonosítóNegyedikSzint;
                    }
                }
                fokonyvComboBox.Items.Add(ss);
            }
            foreach (PénzMozgás penz in XIBaLista)
            {
                ss = penz.azonosító;
                if (penz.azonosítóMásodikSzint != null)
                {
                    ss = ss + "/" + penz.azonosítóMásodikSzint;
                    if (penz.azonosítóHarmadikSzint != null)
                    {
                        ss = ss + "/" + penz.azonosítóHarmadikSzint;
                        if (penz.azonosítóNegyedikSzint != null)
                            ss = ss + "/" + penz.azonosítóNegyedikSzint;
                    }
                }
                fokonyvComboBox.Items.Add(ss);
            }
            foreach (PénzMozgás penz in XIBbLista)
            {
                ss = penz.azonosító;
                if (penz.azonosítóMásodikSzint != null)
                {
                    ss = ss + "/" + penz.azonosítóMásodikSzint;
                    if (penz.azonosítóHarmadikSzint != null)
                    {
                        ss = ss + "/" + penz.azonosítóHarmadikSzint;
                        if (penz.azonosítóNegyedikSzint != null)
                            ss = ss + "/" + penz.azonosítóNegyedikSzint;
                    }
                }
                fokonyvComboBox.Items.Add(ss);
            }
            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right / 2) -(this.Width / 2);
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom / 2) - (this.Height / 2);

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
                case 1: list.Add(new Bejegyzés(ssz + 1, fizetesBox.Text, meghegyzesBox.Text, fokonyvComboBox.SelectedItem.ToString(), k, 0, 0, 0)); break;
                case 2: list.Add(new Bejegyzés(ssz + 1, fizetesBox.Text, meghegyzesBox.Text, fokonyvComboBox.SelectedItem.ToString(), 0, k, 0, 0)); break;
                case 3: list.Add(new Bejegyzés(ssz + 1, fizetesBox.Text, meghegyzesBox.Text, fokonyvComboBox.SelectedItem.ToString(), 0, 0, k, 0)); break;
                case 4: list.Add(new Bejegyzés(ssz + 1, fizetesBox.Text, meghegyzesBox.Text, fokonyvComboBox.SelectedItem.ToString(), 0, 0, 0, k)); break;
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
