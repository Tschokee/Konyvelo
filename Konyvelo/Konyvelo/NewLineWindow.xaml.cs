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

        public void comboboxFeltolt(List<PénzMozgás> Lista)
        {
            foreach (PénzMozgás penz in Lista)
            {
                ss = penz.azonosító;
                fokonyvComboBox.Items.Add(ss);
            }
        }


        //a listához hozzáadó metódus
        public void listaAdd(Bejegyzés b)
        {
            int t = Convert.ToInt32(d.SelectedIndex.ToString());
            //Console.WriteLine(t);
            if (t == -1)
            {
                t = 0;
            }
            list.Insert(Convert.ToInt32(d.SelectedIndex.ToString()) + 1, b);

            //int ssz = list.ElementAt(t).sorSzám;
            int i = 1/*, j = ssz*/;      
            Bejegyzés.globalBankiEgyenleg = 0;
            Bejegyzés.globalPenztariEgyenleg = 0;
            foreach (Bejegyzés be in list)
            {
                be.modositGlobalEgyenleg();
                be.sorSzám = i;
                i++;
            }
        }

        public NewLineWindow(List<Bejegyzés> l, DataGrid d, int s, List<PénzMozgás> ILista, List<PénzMozgás> IILista, List<PénzMozgás> IIILista, List<PénzMozgás> IVLista, List<PénzMozgás> VLista, List<PénzMozgás> XIAaLista, List<PénzMozgás> XIAbLista, List<PénzMozgás> XIBaLista, List<PénzMozgás> XIBbLista, List<PénzMozgás> XIILista, List<PénzMozgás> XIIILista, List<PénzMozgás> XIVLista, List<PénzMozgás> XVLista, List<PénzMozgás> XVILista, List<PénzMozgás> XVIILista, List<PénzMozgás> XVIIILista)
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
            this.fokonyvComboBox.Items.Clear();
            comboboxFeltolt(ILista);
            comboboxFeltolt(IILista);
            comboboxFeltolt(IIILista);
            comboboxFeltolt(IVLista);
            comboboxFeltolt(VLista);
            comboboxFeltolt(XIAaLista);
            comboboxFeltolt(XIAbLista);
            comboboxFeltolt(XIBaLista);
            comboboxFeltolt(XIBbLista);
            comboboxFeltolt(XIILista);
            comboboxFeltolt(XIIILista);
            comboboxFeltolt(XIVLista);
            comboboxFeltolt(XVLista);
            comboboxFeltolt(XVILista);
            comboboxFeltolt(XVIILista);
            comboboxFeltolt(XVIIILista);

            
            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right / 2) -(this.Width / 2);
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom / 2) - (this.Height / 2);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int ssz = 0;
            string bsz = "";
            if (list.Count != 0)
                ssz = list.Last().sorSzám;
            if (bizonylatBox.Text == "")
            {
                switch (s)
                {
                    case 1: bsz = "BeB/" + System.DateTime.Now.Year; break;
                    case 2: bsz = "KiB/" + System.DateTime.Now.Year; break;
                    case 3: bsz = "BeP/" + System.DateTime.Now.Year; break;
                    case 4: bsz = "KiP/" + System.DateTime.Now.Year; break;
                }
            }
            else bsz = bizonylatBox.Text;
            int k = 0;
            try
            {
                if (changeBox.Text.Length != 0) k = Convert.ToInt32(changeBox.Text);

                //listához itt adunk metódussal
                switch (s)
                {
                    case 1: listaAdd(new Bejegyzés(ssz + 1, fizetesBox.Text, megjegyzesBox.Text, fokonyvComboBox.SelectedItem.ToString(), k, 0, 0, 0, bsz)); break;
                    case 2: listaAdd(new Bejegyzés(ssz + 1, fizetesBox.Text, megjegyzesBox.Text, fokonyvComboBox.SelectedItem.ToString(), 0, k, 0, 0, bsz)); break;
                    case 3: listaAdd(new Bejegyzés(ssz + 1, fizetesBox.Text, megjegyzesBox.Text, fokonyvComboBox.SelectedItem.ToString(), 0, 0, k, 0, bsz)); break;
                    case 4: listaAdd(new Bejegyzés(ssz + 1, fizetesBox.Text, megjegyzesBox.Text, fokonyvComboBox.SelectedItem.ToString(), 0, 0, 0, k, bsz)); break;
                    default: break;
                }

                d.Items.Refresh();

                this.Close();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Az érték mezőbe számot kell megadni!", "Hiba");
            }             
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
