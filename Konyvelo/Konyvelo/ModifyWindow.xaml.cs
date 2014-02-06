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
        String ss;

        public void comboboxFeltolt(List<PénzMozgás> Lista)
        {
            foreach (PénzMozgás penz in Lista)
            {
                ss = penz.azonosító;
                fokonyvComboBox.Items.Add(ss);
            }
        }

        public ModifyWindow(List<Bejegyzés> l, DataGrid d, int t, List<PénzMozgás> ILista, List<PénzMozgás> IILista, List<PénzMozgás> IIILista, List<PénzMozgás> IVLista, List<PénzMozgás> VLista, List<PénzMozgás> XIAaLista, List<PénzMozgás> XIAbLista, List<PénzMozgás> XIBaLista, List<PénzMozgás> XIBbLista, List<PénzMozgás> XIILista, List<PénzMozgás> XIIILista, List<PénzMozgás> XIVLista, List<PénzMozgás> XVLista, List<PénzMozgás> XVILista, List<PénzMozgás> XVIILista, List<PénzMozgás> XVIIILista)
        {
            InitializeComponent();
            this.list = l;
            this.d = d;
            this.t = t;
            fizetesBox.Text = l.ElementAt(t).fizetésIdeje;
            meghegyzesBox.Text = l.ElementAt(t).megjegyzés;
            fokonyvComboBox.SelectedItem = l.ElementAt(t).főkönyv;

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

            if (l.ElementAt(t).bankiBevétel != 0)
            {
                changeLabel.Content = "Banki bevétel";
                cahngeBox.Text = l.ElementAt(t).bankiBevétel.ToString();
            }
            if (l.ElementAt(t).bankiKiadás != 0)
            {
                changeLabel.Content = "Banki kiadás";
                cahngeBox.Text = l.ElementAt(t).bankiKiadás.ToString();
            }
            if (l.ElementAt(t).pénztáriBevétel != 0)
            {
                changeLabel.Content = "Pénztári bevétel";
                cahngeBox.Text = l.ElementAt(t).pénztáriBevétel.ToString();
            }
            if(l.ElementAt(t).pénztáriKiadás != 0)
            {
                changeLabel.Content = "Pénztári kiadás";
                cahngeBox.Text = l.ElementAt(t).pénztáriKiadás.ToString();
            }
            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right / 2) - (this.Width / 2);
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom / 2) - (this.Height / 2);
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int s = 0;
            if (list.Count != 0)
                s = list.Last().sorSzám;

            list.ElementAt(t).fizetésIdeje = fizetesBox.Text;
            list.ElementAt(t).megjegyzés = meghegyzesBox.Text;
            list.ElementAt(t).főkönyv = fokonyvComboBox.SelectedItem.ToString();
            
            switch (changeLabel.Content.ToString())
            {
                case "Banki bevétel": list.ElementAt(t).bankiBevétel = Convert.ToInt32(cahngeBox.Text); break;
                case "Banki kiadás": list.ElementAt(t).bankiKiadás = Convert.ToInt32(cahngeBox.Text); break;
                case "Pénztári bevétel": list.ElementAt(t).pénztáriBevétel = Convert.ToInt32(cahngeBox.Text); break;
                case "Pénztári kiadás": list.ElementAt(t).pénztáriKiadás = Convert.ToInt32(cahngeBox.Text); break;
                default: break;
            }

            Bejegyzés.globalBankiEgyenleg = 0;
            Bejegyzés.globalPenztariEgyenleg = 0;
            foreach (Bejegyzés b in list)
            {
                b.modositGlobalEgyenleg();
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
