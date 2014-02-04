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
    /// Interaction logic for ChoiceWindow.xaml
    /// </summary>
    public partial class ChoiceWindow : Window
    {
        public List<Bejegyzés> list;
        public DataGrid d;
        List<PénzMozgás> ILista, IILista, IIILista, IVLista, VLista, XIAaLista, XIAbLista, XIBaLista, XIBbLista;
        public int s;

        public ChoiceWindow(List<Bejegyzés> l, DataGrid d, List<PénzMozgás> ILista, List<PénzMozgás> IILista, List<PénzMozgás> IIILista, List<PénzMozgás> IVLista, List<PénzMozgás> VLista, List<PénzMozgás> XIAaLista, List<PénzMozgás> XIAbLista, List<PénzMozgás> XIBaLista, List<PénzMozgás> XIBbLista)
        {
            InitializeComponent();
            this.list = l;
            this.d = d;
            this.ILista = ILista;
            this.IILista = IILista;
            this.IIILista = IIILista;
            this.IVLista = IVLista;
            this.VLista = VLista;
            this.XIAaLista = XIAaLista;
            this.XIAbLista = XIAbLista;
            this.XIBaLista = XIBaLista;
            this.XIBbLista = XIBbLista;
            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right / 2) - (this.Width / 2);
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom / 2) - (this.Height / 2);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (bankiBevetelbtn.IsChecked == true)
                s = 1;
            if (bankiKiadasbtn.IsChecked == true)
                s = 2;
            if (penztariBevetelbtn.IsChecked == true)
                s = 3;
            if (penztariKiadasbtn.IsChecked == true)
                s = 4;
            Window NWL = new NewLineWindow(list, d, s, ILista, IILista, IIILista, IVLista, VLista, XIAaLista, XIAbLista, XIBaLista, XIBbLista);
            NWL.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}