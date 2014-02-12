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
    /// Interaction logic for FokonyvWindow.xaml
    /// </summary>
    public partial class FokonyvWindow : Window
    {
        private int year = PénzMozgás.évSzám;
        List<Bejegyzés> I = new List<Bejegyzés>(), II1 = new List<Bejegyzés>(), II2 = new List<Bejegyzés>(), II3 = new List<Bejegyzés>(), II4 = new List<Bejegyzés>(), II5 = new List<Bejegyzés>(), II6 = new List<Bejegyzés>(), III1 = new List<Bejegyzés>(), III2 = new List<Bejegyzés>(), III3 = new List<Bejegyzés>(), III4 = new List<Bejegyzés>(), III5 = new List<Bejegyzés>(), III6 = new List<Bejegyzés>(), III7 = new List<Bejegyzés>(), III8 = new List<Bejegyzés>(), III9 = new List<Bejegyzés>(), III10 = new List<Bejegyzés>(), IV1 = new List<Bejegyzés>(), IV2 = new List<Bejegyzés>(), IV3 = new List<Bejegyzés>(), IV4 = new List<Bejegyzés>(), IV5 = new List<Bejegyzés>(), IV6 = new List<Bejegyzés>(), IV7 = new List<Bejegyzés>(), IV8 = new List<Bejegyzés>(), IV9 = new List<Bejegyzés>(), IV10 = new List<Bejegyzés>(), V1 = new List<Bejegyzés>(), V2 = new List<Bejegyzés>(), V3 = new List<Bejegyzés>(), V4 = new List<Bejegyzés>(), V5 = new List<Bejegyzés>(), V6 = new List<Bejegyzés>(),
            XIAa1 = new List<Bejegyzés>(), XIAa2 = new List<Bejegyzés>(), XIAa3 = new List<Bejegyzés>(), XIAa4 = new List<Bejegyzés>(), XIAa5 = new List<Bejegyzés>(), XIAa6 = new List<Bejegyzés>(), XIAa7 = new List<Bejegyzés>(), XIAa8 = new List<Bejegyzés>(), XIAa9 = new List<Bejegyzés>(), XIAa10 = new List<Bejegyzés>(), XIAa11 = new List<Bejegyzés>(), XIAa12 = new List<Bejegyzés>(), XIAa13 = new List<Bejegyzés>(), XIAa14 = new List<Bejegyzés>(), XIAb1 = new List<Bejegyzés>(), XIAb2 = new List<Bejegyzés>(), XIAb3 = new List<Bejegyzés>(), XIBa1 = new List<Bejegyzés>(), XIBa2 = new List<Bejegyzés>(), XIBa3 = new List<Bejegyzés>(), XIBa4 = new List<Bejegyzés>(), XIBa5 = new List<Bejegyzés>(), XIBa6 = new List<Bejegyzés>(), XIBa7 = new List<Bejegyzés>(), XIBa8 = new List<Bejegyzés>(), XIBa9 = new List<Bejegyzés>(), XIBa10 = new List<Bejegyzés>(),
            XIBb1 = new List<Bejegyzés>(), XIBb2 = new List<Bejegyzés>(), XIBb3 = new List<Bejegyzés>(), XII1 = new List<Bejegyzés>(), XII2 = new List<Bejegyzés>(), XII3 = new List<Bejegyzés>(), XII4 = new List<Bejegyzés>(), XII5 = new List<Bejegyzés>(), XII6 = new List<Bejegyzés>(), XII7 = new List<Bejegyzés>(), XII8 = new List<Bejegyzés>(), XII9 = new List<Bejegyzés>(), XII10 = new List<Bejegyzés>(), XII11 = new List<Bejegyzés>(), XII12 = new List<Bejegyzés>(), XII13 = new List<Bejegyzés>(), XII14 = new List<Bejegyzés>(), XIII1 = new List<Bejegyzés>(), XIII2 = new List<Bejegyzés>(), XIII3 = new List<Bejegyzés>(), XIII4 = new List<Bejegyzés>(), XIII5 = new List<Bejegyzés>(), XIII6 = new List<Bejegyzés>(), XIII7 = new List<Bejegyzés>(), XIII8 = new List<Bejegyzés>(), XIII9 = new List<Bejegyzés>(), XIII10 = new List<Bejegyzés>(), XIII11 = new List<Bejegyzés>(), XIII12 = new List<Bejegyzés>(), XIII13 = new List<Bejegyzés>(), XIII14 = new List<Bejegyzés>(), XIII15 = new List<Bejegyzés>(),
            XIV1 = new List<Bejegyzés>(), XIV2 = new List<Bejegyzés>(), XIV3 = new List<Bejegyzés>(), XIV4 = new List<Bejegyzés>(), XIV5 = new List<Bejegyzés>(), XIV6 = new List<Bejegyzés>(), XIV7 = new List<Bejegyzés>(), XIV8 = new List<Bejegyzés>(), XIV9 = new List<Bejegyzés>(), XIV10 = new List<Bejegyzés>(), XIV11 = new List<Bejegyzés>(), XIV12 = new List<Bejegyzés>(), XIV13 = new List<Bejegyzés>(), XIV14 = new List<Bejegyzés>(), XV1 = new List<Bejegyzés>(), XV2 = new List<Bejegyzés>(), XV3 = new List<Bejegyzés>(), XV4 = new List<Bejegyzés>(), XV5 = new List<Bejegyzés>(), XV6 = new List<Bejegyzés>(), XV7 = new List<Bejegyzés>(), XVI = new List<Bejegyzés>(), XVII1 = new List<Bejegyzés>(), XVII1a = new List<Bejegyzés>(), XVII1b = new List<Bejegyzés>(), XVII2 = new List<Bejegyzés>(), XVII3 = new List<Bejegyzés>(), XVII4 = new List<Bejegyzés>(), XVII5 = new List<Bejegyzés>(), XVII6 = new List<Bejegyzés>(), XVIII1 = new List<Bejegyzés>(), XVIII2 = new List<Bejegyzés>(), XVIII3 = new List<Bejegyzés>(), XVIII4 = new List<Bejegyzés>(), XVIII5 = new List<Bejegyzés>(), XVIII6 = new List<Bejegyzés>();
        double m = 0;
        private void listakNullaz()
        {
            I = new List<Bejegyzés>(); II1 = new List<Bejegyzés>(); II2 = new List<Bejegyzés>(); II3 = new List<Bejegyzés>(); II4 = new List<Bejegyzés>(); II5 = new List<Bejegyzés>(); II6 = new List<Bejegyzés>(); III1 = new List<Bejegyzés>(); III2 = new List<Bejegyzés>(); III3 = new List<Bejegyzés>(); III4 = new List<Bejegyzés>(); III5 = new List<Bejegyzés>(); III6 = new List<Bejegyzés>(); III7 = new List<Bejegyzés>(); III8 = new List<Bejegyzés>(); III9 = new List<Bejegyzés>(); III10 = new List<Bejegyzés>(); IV1 = new List<Bejegyzés>(); IV2 = new List<Bejegyzés>(); IV3 = new List<Bejegyzés>(); IV4 = new List<Bejegyzés>(); IV5 = new List<Bejegyzés>(); IV6 = new List<Bejegyzés>(); IV7 = new List<Bejegyzés>(); IV8 = new List<Bejegyzés>(); IV9 = new List<Bejegyzés>(); IV10 = new List<Bejegyzés>(); V1 = new List<Bejegyzés>(); V2 = new List<Bejegyzés>(); V3 = new List<Bejegyzés>(); V4 = new List<Bejegyzés>(); V5 = new List<Bejegyzés>(); V6 = new List<Bejegyzés>();
            XIAa1 = new List<Bejegyzés>(); XIAa2 = new List<Bejegyzés>(); XIAa3 = new List<Bejegyzés>(); XIAa4 = new List<Bejegyzés>(); XIAa5 = new List<Bejegyzés>(); XIAa6 = new List<Bejegyzés>(); XIAa7 = new List<Bejegyzés>(); XIAa8 = new List<Bejegyzés>(); XIAa9 = new List<Bejegyzés>(); XIAa10 = new List<Bejegyzés>(); XIAa11 = new List<Bejegyzés>(); XIAa12 = new List<Bejegyzés>(); XIAa13 = new List<Bejegyzés>(); XIAa14 = new List<Bejegyzés>(); XIAb1 = new List<Bejegyzés>(); XIAb2 = new List<Bejegyzés>(); XIAb3 = new List<Bejegyzés>(); XIBa1 = new List<Bejegyzés>(); XIBa2 = new List<Bejegyzés>(); XIBa3 = new List<Bejegyzés>(); XIBa4 = new List<Bejegyzés>(); XIBa5 = new List<Bejegyzés>(); XIBa6 = new List<Bejegyzés>(); XIBa7 = new List<Bejegyzés>(); XIBa8 = new List<Bejegyzés>(); XIBa9 = new List<Bejegyzés>(); XIBa10 = new List<Bejegyzés>();
            XIBb1 = new List<Bejegyzés>(); XIBb2 = new List<Bejegyzés>(); XIBb3 = new List<Bejegyzés>(); XII1 = new List<Bejegyzés>(); XII2 = new List<Bejegyzés>(); XII3 = new List<Bejegyzés>(); XII4 = new List<Bejegyzés>(); XII5 = new List<Bejegyzés>(); XII6 = new List<Bejegyzés>(); XII7 = new List<Bejegyzés>(); XII8 = new List<Bejegyzés>(); XII9 = new List<Bejegyzés>(); XII10 = new List<Bejegyzés>(); XII11 = new List<Bejegyzés>(); XII12 = new List<Bejegyzés>(); XII13 = new List<Bejegyzés>(); XII14 = new List<Bejegyzés>(); XIII1 = new List<Bejegyzés>(); XIII2 = new List<Bejegyzés>(); XIII3 = new List<Bejegyzés>(); XIII4 = new List<Bejegyzés>(); XIII5 = new List<Bejegyzés>(); XIII6 = new List<Bejegyzés>(); XIII7 = new List<Bejegyzés>(); XIII8 = new List<Bejegyzés>(); XIII9 = new List<Bejegyzés>(); XIII10 = new List<Bejegyzés>(); XIII11 = new List<Bejegyzés>(); XIII12 = new List<Bejegyzés>(); XIII13 = new List<Bejegyzés>(); XIII14 = new List<Bejegyzés>(); XIII15 = new List<Bejegyzés>();
            XIV1 = new List<Bejegyzés>(); XIV2 = new List<Bejegyzés>(); XIV3 = new List<Bejegyzés>(); XIV4 = new List<Bejegyzés>(); XIV5 = new List<Bejegyzés>(); XIV6 = new List<Bejegyzés>(); XIV7 = new List<Bejegyzés>(); XIV8 = new List<Bejegyzés>(); XIV9 = new List<Bejegyzés>(); XIV10 = new List<Bejegyzés>(); XIV11 = new List<Bejegyzés>(); XIV12 = new List<Bejegyzés>(); XIV13 = new List<Bejegyzés>(); XIV14 = new List<Bejegyzés>(); XV1 = new List<Bejegyzés>(); XV2 = new List<Bejegyzés>(); XV3 = new List<Bejegyzés>(); XV4 = new List<Bejegyzés>(); XV5 = new List<Bejegyzés>(); XV6 = new List<Bejegyzés>(); XV7 = new List<Bejegyzés>(); XVI = new List<Bejegyzés>(); XVII1 = new List<Bejegyzés>(); XVII1a = new List<Bejegyzés>(); XVII1b = new List<Bejegyzés>(); XVII2 = new List<Bejegyzés>(); XVII3 = new List<Bejegyzés>(); XVII4 = new List<Bejegyzés>(); XVII5 = new List<Bejegyzés>(); XVII6 = new List<Bejegyzés>(); XVIII1 = new List<Bejegyzés>(); XVIII2 = new List<Bejegyzés>(); XVIII3 = new List<Bejegyzés>(); XVIII4 = new List<Bejegyzés>(); XVIII5 = new List<Bejegyzés>(); XVIII6 = new List<Bejegyzés>();
        }
        int Iosszeg = 0, IIosszeg = 0, IIIosszeg = 0,
             IVosszeg = 0, Vosszeg = 0, XIAaosszeg = 0, XIAbosszeg = 0,
             XIBaosszeg = 0, XIBbosszeg = 0, XIIosszeg = 0, XIIIosszeg = 0,
             XIVosszeg = 0, XVosszeg = 0, XVIosszeg = 0, XVIIosszeg = 0, XVIIIosszeg = 0;
        private void generateGrid(List<Bejegyzés> l, int f)
        {
            DataGrid myDataGrid = new DataGrid();
            myDataGrid.CanUserAddRows = false;
            myDataGrid.IsReadOnly = true;
            //myDataGrid.Height = l.Count * 19.5;
            myDataGrid.Width = 590;
            myDataGrid.Margin = new Thickness(0, m, 0, 0);
            myDataGrid.ItemsSource = l;
            myDataGrid.AutoGenerateColumns = false;
            DataGridTextColumn col1 = new DataGridTextColumn();
            col1.Binding = new Binding("sorSzám");
            col1.Width = 100;
            myDataGrid.Columns.Add(col1);
            DataGridTextColumn col2 = new DataGridTextColumn();
            col2.Binding = new Binding("fizetésIdeje");
            col2.Width = 100;
            myDataGrid.Columns.Add(col2);
            DataGridTextColumn col3 = new DataGridTextColumn();
            col3.Binding = new Binding("megjegyzés");
            col3.Width = 250;
            myDataGrid.Columns.Add(col3);
            DataGridTextColumn col4 = new DataGridTextColumn();
            if (f <= 5)
            {
                col4.Binding = new Binding("osszBevetel");
            }
            else
            { 
                col4.Binding = new Binding("osszKiadas");
            }
            col4.Width = 120;
            myDataGrid.Columns.Add(col4);
            myDataGrid.HorizontalAlignment = HorizontalAlignment.Left;
            myDataGrid.VerticalAlignment = VerticalAlignment.Top;
            myDataGrid.HeadersVisibility = DataGridHeadersVisibility.None;
            myGrid.Children.Add(myDataGrid);
            m += l.Count * 19;
        }

        private void generateAll(List<Bejegyzés> bl, List<PénzMozgás> pl, int ssz, int f)
        {
            if (bl.Count != 0)
            {
                Label blLabel = new Label();
                blLabel.Content = pl[ssz].azonosító + ". " + pl[ssz].név;
                blLabel.Margin = new Thickness(0, m, 0, 0);
                blLabel.Height = 27;
                m += 27;
                blLabel.HorizontalAlignment = HorizontalAlignment.Left;
                blLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(blLabel);

                generateGrid(bl, f);

                Label blosszNevLabel = new Label();
                blosszNevLabel.Content = pl[ssz].azonosító + ". " + pl[ssz].név + "összesen:";
                blosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                blosszNevLabel.Height = 27;
                blosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                blosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(blosszNevLabel);

                Label blosszErtekLabel = new Label();
                blosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                blosszErtekLabel.Height = 27;
                blosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                blosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                foreach (Bejegyzés b in bl)
                {
                    if (f <= 5)
                    {
                        blosszErtekLabel.Content = Convert.ToInt32(blosszErtekLabel.Content) + b.osszBevetel;
                    }
                    else
                    {
                        blosszErtekLabel.Content = Convert.ToInt32(blosszErtekLabel.Content) + b.osszKiadas;
                    }
                }
                myGrid.Children.Add(blosszErtekLabel);
                switch (f)
                {
                    case 1: Iosszeg += Convert.ToInt32(blosszErtekLabel.Content); break;
                    case 2: IIosszeg += Convert.ToInt32(blosszErtekLabel.Content); break;
                    case 3: IIIosszeg += Convert.ToInt32(blosszErtekLabel.Content); break;
                    case 4: IVosszeg += Convert.ToInt32(blosszErtekLabel.Content); break;
                    case 5: Vosszeg += Convert.ToInt32(blosszErtekLabel.Content); break;
                    case 6: XIAaosszeg += Convert.ToInt32(blosszErtekLabel.Content); break;
                    case 7: XIAbosszeg += Convert.ToInt32(blosszErtekLabel.Content); break;
                    case 8: XIBaosszeg += Convert.ToInt32(blosszErtekLabel.Content); break;
                    case 9: XIBbosszeg += Convert.ToInt32(blosszErtekLabel.Content); break;
                    case 10: XIIosszeg += Convert.ToInt32(blosszErtekLabel.Content); break;
                    case 11: XIIIosszeg += Convert.ToInt32(blosszErtekLabel.Content); break;
                    case 12: XIVosszeg += Convert.ToInt32(blosszErtekLabel.Content); break;
                    case 13: XVosszeg += Convert.ToInt32(blosszErtekLabel.Content); break;
                    case 14: XVIosszeg += Convert.ToInt32(blosszErtekLabel.Content); break;
                    case 15: XVIIosszeg += Convert.ToInt32(blosszErtekLabel.Content); break;
                    case 16: XVIIIosszeg += Convert.ToInt32(blosszErtekLabel.Content); break;
                }
                m += 30;

            }
        }
        public FokonyvWindow(List<Bejegyzés> bl,List<PénzMozgás> ILista, List<PénzMozgás> IILista, List<PénzMozgás> IIILista,
            List<PénzMozgás> IVLista, List<PénzMozgás> VLista, List<PénzMozgás> XIAaLista, List<PénzMozgás> XIAbLista,
            List<PénzMozgás> XIBaLista, List<PénzMozgás> XIBbLista, List<PénzMozgás> XIILista, List<PénzMozgás> XIIILista,
            List<PénzMozgás> XIVLista, List<PénzMozgás> XVLista, List<PénzMozgás> XVILista, List<PénzMozgás> XVIILista,
            List<PénzMozgás> XVIIILista)
        {
            InitializeComponent();
            listakNullaz();
            m = 0;
            //myGrid.Height = bl.Count * 50;
            foreach (Bejegyzés b in bl)
            {
                switch (b.főkönyv)
                {
                    case "I": I.Add(b); break;
                    case "II/1" : II1.Add(b); break;
                    case "II/2" : II2.Add(b); break;
                    case "II/3" : II3.Add(b); break;
                    case "II/4" : II4.Add(b); break;
                    case "II/5" : II5.Add(b); break;
                    case "II/6" : II6.Add(b); break;
                    case "III/1": III1.Add(b); break;
                    case "III/2": III2.Add(b); break;
                    case "III/3": III3.Add(b); break;
                    case "III/4": III4.Add(b); break;
                    case "III/5": III5.Add(b); break;
                    case "III/6": III6.Add(b); break;
                    case "III/7": III7.Add(b); break;
                    case "III/8": III8.Add(b); break;
                    case "III/9": III9.Add(b); break;
                    case "III/10": III10.Add(b); break;
                    case "IV/1": IV1.Add(b); break;
                    case "IV/2": IV2.Add(b); break;
                    case "IV/3": IV3.Add(b); break;
                    case "IV/4": IV4.Add(b); break;
                    case "IV/5": IV5.Add(b); break;
                    case "IV/6": IV6.Add(b); break;
                    case "IV/7": IV7.Add(b); break;
                    case "IV/8": IV8.Add(b); break;
                    case "IV/9": IV9.Add(b); break;
                    case "IV/10": IV10.Add(b); break;
                    case "V/1": V1.Add(b); break;
                    case "V/2": V2.Add(b); break;
                    case "V/3": V3.Add(b); break;
                    case "V/4": V4.Add(b); break;
                    case "V/5": V5.Add(b); break;
                    case "V/6": V6.Add(b); break;
                    case "XI/A/a/1": XIAa1.Add(b); break;
                    case "XI/A/a/2": XIAa2.Add(b); break;
                    case "XI/A/a/3": XIAa3.Add(b); break;
                    case "XI/A/a/4": XIAa4.Add(b); break;
                    case "XI/A/a/5": XIAa5.Add(b); break;
                    case "XI/A/a/6": XIAa6.Add(b); break;
                    case "XI/A/a/7": XIAa7.Add(b); break;
                    case "XI/A/a/8": XIAa8.Add(b); break;
                    case "XI/A/a/9": XIAa9.Add(b); break;
                    case "XI/A/a/10": XIAa10.Add(b); break;
                    case "XI/A/a/11": XIAa11.Add(b); break;
                    case "XI/A/a/12": XIAa12.Add(b); break;
                    case "XI/A/a/13": XIAa13.Add(b); break;
                    case "XI/A/a/14": XIAa14.Add(b); break;
                    case "XI/A/b/15": XIAb1.Add(b); break;
                    case "XI/A/b/16": XIAb2.Add(b); break;
                    case "XI/A/b/17": XIAb3.Add(b); break;
                    case "XI/B/a/1": XIBa1.Add(b); break;
                    case "XI/B/a/2": XIBa2.Add(b); break;
                    case "XI/B/a/3": XIBa3.Add(b); break;
                    case "XI/B/a/4": XIBa4.Add(b); break;
                    case "XI/B/a/5": XIBa5.Add(b); break;
                    case "XI/B/a/6": XIBa6.Add(b); break;
                    case "XI/B/a/7": XIBa7.Add(b); break;
                    case "XI/B/a/8": XIBa8.Add(b); break;
                    case "XI/B/a/9": XIBa9.Add(b); break;
                    case "XI/B/a/10": XIBa10.Add(b); break;
                    case "XI/B/b/11": XIBb1.Add(b); break;
                    case "XI/B/b/12": XIBb2.Add(b); break;
                    case "XI/B/b/13": XIBb3.Add(b); break;
                    case "XII/1": XII1.Add(b); break;
                    case "XII/2": XII2.Add(b); break;
                    case "XII/3": XII3.Add(b); break;
                    case "XII/3/a": XII4.Add(b); break;
                    case "XII/3/b": XII5.Add(b); break;
                    case "XII/3/c": XII6.Add(b); break;
                    case "XII/3/d": XII7.Add(b); break;
                    case "XII/3/e": XII8.Add(b); break;
                    case "XII/4": XII9.Add(b); break;
                    case "XII/5": XII10.Add(b); break;
                    case "XII/6": XII11.Add(b); break;
                    case "XII/7": XII12.Add(b); break;
                    case "XII/8": XII13.Add(b); break;
                    case "XII/9": XII14.Add(b); break;
                    case "XIII/1": XIII1.Add(b); break;
                    case "XIII/2": XIII2.Add(b); break;
                    case "XIII/3": XIII3.Add(b); break;
                    case "XIII/4": XIII4.Add(b); break;
                    case "XIII/5": XIII5.Add(b); break;
                    case "XIII/6": XIII6.Add(b); break;
                    case "XIII/7": XIII7.Add(b); break;
                    case "XIII/8": XIII8.Add(b); break;
                    case "XIII/9": XIII9.Add(b); break;
                    case "XIII/10": XIII10.Add(b); break;
                    case "XIII/11": XIII11.Add(b); break;
                    case "XIII/12": XIII12.Add(b); break;
                    case "XIII/13": XIII13.Add(b); break;
                    case "XIII/14": XIII14.Add(b); break;
                    case "XIII/15": XIII15.Add(b); break;
                    case "XIV/1": XIV1.Add(b); break;
                    case "XIV/2": XIV2.Add(b); break;
                    case "XIV/3": XIV3.Add(b); break;
                    case "XIV/4": XIV4.Add(b); break;
                    case "XIV/5": XIV5.Add(b); break;
                    case "XIV/6": XIV6.Add(b); break;
                    case "XIV/7": XIV7.Add(b); break;
                    case "XIV/8": XIV8.Add(b); break;
                    case "XIV/9": XIV9.Add(b); break;
                    case "XIV/10": XIV10.Add(b); break;
                    case "XIV/11": XIV11.Add(b); break;
                    case "XIV/12": XIV12.Add(b); break;
                    case "XIV/13": XIV13.Add(b); break;
                    case "XIV/14": XIV14.Add(b); break;
                    case "XV/1": XV1.Add(b); break;
                    case "XV/2": XV2.Add(b); break;
                    case "XV/3": XV3.Add(b); break;
                    case "XV/4": XV4.Add(b); break;
                    case "XV/5": XV5.Add(b); break;
                    case "XV/6": XV6.Add(b); break;
                    case "XV/7": XV7.Add(b); break;
                    case "XVI": XVI.Add(b); break;
                    case "XVII/1": XVII1.Add(b); break;
                    case "XVII/1/a": XVII1a.Add(b); break;
                    case "XVII/1/b": XVII1b.Add(b); break;
                    case "XVII/2": XVII2.Add(b); break;
                    case "XVII/3": XVII3.Add(b); break;
                    case "XVII/4": XVII4.Add(b); break;
                    case "XVII/5": XVII5.Add(b); break;
                    case "XVII/6": XVII6.Add(b); break;
                    case "XVIII/1": XVIII1.Add(b); break;
                    case "XVIII/2": XVIII2.Add(b); break;
                    case "XVIII/3": XVIII3.Add(b); break;
                    case "XVIII/4": XVIII4.Add(b); break;
                    case "XVIII/5": XVIII5.Add(b); break;
                    case "XVIII/6": XVIII6.Add(b); break;
                    default : break;
                }
            }

            //folabel
            Label ILabel = new Label();
            ILabel.Content = "I. Egyházfenntartói járulék";
            ILabel.Margin = new Thickness(0, 0, 0, 0);
            ILabel.Height = 27;         
            m += 27;
            ILabel.HorizontalAlignment = HorizontalAlignment.Left;
            ILabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(ILabel);

            if (I.Count != 0)
            {
                generateGrid(I, 1);
                Label IosszNevLabel = new Label();
                IosszNevLabel.Content = "I. Egyházfenntartói járulék összesen";
                IosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                IosszNevLabel.Height = 27;
                IosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                IosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(IosszNevLabel);

                Label IosszErtekLabel = new Label();
                IosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                IosszErtekLabel.Height = 27;
                IosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                IosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                foreach (Bejegyzés b in I)
                {
                    IosszErtekLabel.Content = Convert.ToInt32(IosszErtekLabel.Content) + b.osszBevetel;
                }
                Iosszeg = Convert.ToInt32(IosszErtekLabel.Content);
                myGrid.Children.Add(IosszErtekLabel);
                m += 30;
            }

            //folabel
            Label IILabel = new Label();
            IILabel.Content = "II. Perselypénzek";
            IILabel.Margin = new Thickness(0, m, 0, 0);
            IILabel.Height = 27;
            m += 27;
            IILabel.HorizontalAlignment = HorizontalAlignment.Left;
            IILabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(IILabel);

            generateAll(II1, IILista, 0, 2);
            generateAll(II2, IILista, 1, 2);
            generateAll(II3, IILista, 2, 2);
            generateAll(II4, IILista, 3, 2);
            generateAll(II5, IILista, 4, 2);
            generateAll(II6, IILista, 5, 2);

            if (II1.Count != 0 || II2.Count != 0 || II3.Count != 0 || II4.Count != 0 || II5.Count != 0 || II6.Count != 0)
            {
                Label IIosszNevLabel = new Label();
                IIosszNevLabel.Content = "II. Perselypénzek összesen:";
                IIosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                IIosszNevLabel.Height = 27;
                IIosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                IIosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(IIosszNevLabel);

                Label IIosszErtekLabel = new Label();
                IIosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                IIosszErtekLabel.Height = 27;
                IIosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                IIosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                IIosszErtekLabel.Content = IIosszeg;
                myGrid.Children.Add(IIosszErtekLabel);
                m += 30;
            }

            //folabel
            Label IIILabel = new Label();
            IIILabel.Content = "III. Adományok";
            IIILabel.Margin = new Thickness(0, m, 0, 0);
            IIILabel.Height = 27;
            m += 27;
            IIILabel.HorizontalAlignment = HorizontalAlignment.Left;
            IIILabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(IIILabel);

            generateAll(III1, IIILista, 0, 3);
            generateAll(III2, IIILista, 1, 3);
            generateAll(III3, IIILista, 3, 3);
            generateAll(III4, IIILista, 3, 3);
            generateAll(III5, IIILista, 4, 3);
            generateAll(III6, IIILista, 5, 3);
            generateAll(III7, IIILista, 6, 3);
            generateAll(III8, IIILista, 7, 3);
            generateAll(III9, IIILista, 8, 3);
            generateAll(III10, IIILista, 9, 3);

            if (III1.Count != 0 || III2.Count != 0 || III3.Count != 0 || III4.Count != 0 || III5.Count != 0 || III6.Count != 0 || III7.Count != 0 || III8.Count != 0 || III9.Count != 0 || III10.Count != 0)
            {
                Label IIIosszNevLabel = new Label();
                IIIosszNevLabel.Content = "III. Adományok összesen:";
                IIIosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                IIIosszNevLabel.Height = 27;
                IIIosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                IIIosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(IIIosszNevLabel);

                Label IIIosszErtekLabel = new Label();
                IIIosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                IIIosszErtekLabel.Height = 27;
                IIIosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                IIIosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                IIIosszErtekLabel.Content = IIIosszeg;
                myGrid.Children.Add(IIIosszErtekLabel);
                m += 30;
            }

            //folabel
            Label IVLabel = new Label();
            IVLabel.Content = "IV. Egyéb bevételek";
            IVLabel.Margin = new Thickness(0, m, 0, 0);
            IVLabel.Height = 27;
            m += 27;
            IVLabel.HorizontalAlignment = HorizontalAlignment.Left;
            IVLabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(IVLabel);

            generateAll(IV1, IVLista, 0, 4);
            generateAll(IV2, IVLista, 1, 4);
            generateAll(IV3, IVLista, 3, 4);
            generateAll(IV4, IVLista, 3, 4);
            generateAll(IV5, IVLista, 4, 4);
            generateAll(IV6, IVLista, 5, 4);
            generateAll(IV7, IVLista, 6, 4);
            generateAll(IV8, IVLista, 7, 4);
            generateAll(IV9, IVLista, 8, 4);
            generateAll(IV10, IVLista, 9, 4);

            if (IV1.Count != 0 || IV2.Count != 0 || IV3.Count != 0 || IV4.Count != 0 || IV5.Count != 0 || IV6.Count != 0 || IV7.Count != 0 || IV8.Count != 0 || IV9.Count != 0 || IV10.Count != 0)
            {
                Label IVosszNevLabel = new Label();
                IVosszNevLabel.Content = "IV. Egyéb bevételek összesen:";
                IVosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                IVosszNevLabel.Height = 27;
                IVosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                IVosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(IVosszNevLabel);

                Label IVosszErtekLabel = new Label();
                IVosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                IVosszErtekLabel.Height = 27;
                IVosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                IVosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                IVosszErtekLabel.Content = IVosszeg;
                myGrid.Children.Add(IVosszErtekLabel);
                m += 30;
            }
            //össes saját bevétel label
            Label osszSajatBevetelNevLabel = new Label();
            osszSajatBevetelNevLabel.Content = "Az egyházközség " + year + ". évi saját bevételei összesen:";
            osszSajatBevetelNevLabel.Margin = new Thickness(0, m, 0, 0);
            osszSajatBevetelNevLabel.Height = 27;
            osszSajatBevetelNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
            osszSajatBevetelNevLabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(osszSajatBevetelNevLabel);

            Label osszSajatBevetelErtekLabel = new Label();
            osszSajatBevetelErtekLabel.Margin = new Thickness(449, m, 0, 0);
            osszSajatBevetelErtekLabel.Height = 27;
            osszSajatBevetelErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
            osszSajatBevetelErtekLabel.VerticalAlignment = VerticalAlignment.Top;
            osszSajatBevetelErtekLabel.Content = Iosszeg + IIosszeg + IIIosszeg + IVosszeg;
            myGrid.Children.Add(osszSajatBevetelErtekLabel);
            m += 30;


            //folabel
            Label VLabel = new Label();
            VLabel.Content = "V. Átvett pénzeszközök";
            VLabel.Margin = new Thickness(0, m, 0, 0);
            VLabel.Height = 27;
            m += 27;
            VLabel.HorizontalAlignment = HorizontalAlignment.Left;
            VLabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(VLabel);

            generateAll(V1, VLista, 0, 5);
            generateAll(V2, VLista, 1, 5);
            generateAll(V3, VLista, 2, 5);
            generateAll(V4, VLista, 3, 5);
            generateAll(V5, VLista, 4, 5);
            generateAll(V6, VLista, 5, 5);

            if (V1.Count != 0 || V2.Count != 0 || V3.Count != 0 || V4.Count != 0 || V5.Count != 0 || V6.Count != 0)
            {
                Label VosszNevLabel = new Label();
                VosszNevLabel.Content = "V. Átvett pénzeszközök összesen:";
                VosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                VosszNevLabel.Height = 27;
                VosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                VosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(VosszNevLabel);

                Label VosszErtekLabel = new Label();
                VosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                VosszErtekLabel.Height = 27;
                VosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                VosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                VosszErtekLabel.Content = Vosszeg;
                myGrid.Children.Add(VosszErtekLabel);
                m += 30;
            }

            //összes bevétel label
            Label osszBevetelNevLabel = new Label();
            osszBevetelNevLabel.Content = "Az egyházközség " + year + ". évi bevételei összesen:";
            osszBevetelNevLabel.Margin = new Thickness(0, m, 0, 0);
            osszBevetelNevLabel.Height = 27;
            osszBevetelNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
            osszBevetelNevLabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(osszBevetelNevLabel);

            Label osszBevetelErtekLabel = new Label();
            osszBevetelErtekLabel.Margin = new Thickness(449, m, 0, 0);
            osszBevetelErtekLabel.Height = 27;
            osszBevetelErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
            osszBevetelErtekLabel.VerticalAlignment = VerticalAlignment.Top;
            osszBevetelErtekLabel.Content = Iosszeg + IIosszeg + IIIosszeg + IVosszeg + Vosszeg;
            myGrid.Children.Add(osszBevetelErtekLabel);
            m += 30;

            //folabel
            Label XIAaLabel = new Label();
            XIAaLabel.Content = "XIAa. Javadalmak";
            XIAaLabel.Margin = new Thickness(0, m, 0, 0);
            XIAaLabel.Height = 27;
            m += 27;
            XIAaLabel.HorizontalAlignment = HorizontalAlignment.Left;
            XIAaLabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(XIAaLabel);

            generateAll(XIAa1, XIAaLista, 0, 6);
            generateAll(XIAa2, XIAaLista, 1, 6);
            generateAll(XIAa3, XIAaLista, 3, 6);
            generateAll(XIAa4, XIAaLista, 3, 6);
            generateAll(XIAa5, XIAaLista, 4, 6);
            generateAll(XIAa6, XIAaLista, 5, 6);
            generateAll(XIAa7, XIAaLista, 6, 6);
            generateAll(XIAa8, XIAaLista, 7, 6);
            generateAll(XIAa9, XIAaLista, 8, 6);
            generateAll(XIAa10, XIAaLista, 9, 6);
            generateAll(XIAa11, XIAaLista, 10, 6);
            generateAll(XIAa12, XIAaLista, 11, 6);
            generateAll(XIAa13, XIAaLista, 12, 6);
            generateAll(XIAa14, XIAaLista, 13, 6);

            if (XIAa1.Count != 0 || XIAa2.Count != 0 || XIAa3.Count != 0 || XIAa4.Count != 0 || XIAa5.Count != 0 || XIAa6.Count != 0 || XIAa7.Count != 0 || XIAa8.Count != 0 || XIAa9.Count != 0 || XIAa10.Count != 0 || XIAa11.Count != 0 || XIAa12.Count != 0 || XIAa13.Count != 0 || XIAa14.Count != 0)
            {
                Label XIAaosszNevLabel = new Label();
                XIAaosszNevLabel.Content = "XIAa. Javadalmak összesen:";
                XIAaosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                XIAaosszNevLabel.Height = 27;
                XIAaosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIAaosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(XIAaosszNevLabel);

                Label XIAaosszErtekLabel = new Label();
                XIAaosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                XIAaosszErtekLabel.Height = 27;
                XIAaosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIAaosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                XIAaosszErtekLabel.Content = XIAaosszeg;
                myGrid.Children.Add(XIAaosszErtekLabel);
                m += 30;
            }

            //folabel
            Label XIAbLabel = new Label();
            XIAbLabel.Content = "XIAb. Közterhek";
            XIAbLabel.Margin = new Thickness(0, m, 0, 0);
            XIAbLabel.Height = 27;
            m += 27;
            XIAbLabel.HorizontalAlignment = HorizontalAlignment.Left;
            XIAbLabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(XIAbLabel);

            generateAll(XIAb1, XIAbLista, 0, 7);
            generateAll(XIAb2, XIAbLista, 1, 7);
            generateAll(XIAb3, XIAbLista, 2, 7);

            if (XIAb1.Count != 0 || XIAb2.Count != 0 || XIAb3.Count != 0 )
            {
                Label XIAbosszNevLabel = new Label();
                XIAbosszNevLabel.Content = "XIAb. Közterhek összesen:";
                XIAbosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                XIAbosszNevLabel.Height = 27;
                XIAbosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIAbosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(XIAbosszNevLabel);

                Label XIAbosszErtekLabel = new Label();
                XIAbosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                XIAbosszErtekLabel.Height = 27;
                XIAbosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIAbosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                XIAbosszErtekLabel.Content = XIAbosszeg;
                myGrid.Children.Add(XIAbosszErtekLabel);
                m += 30;
            }

            if (XIAa1.Count != 0 || XIAa2.Count != 0 || XIAa3.Count != 0 || XIAa4.Count != 0 || XIAa5.Count != 0 || XIAa6.Count != 0 || XIAa7.Count != 0 || XIAa8.Count != 0 || XIAa9.Count != 0 || XIAa10.Count != 0 || XIAa11.Count != 0 || XIAa12.Count != 0 || XIAa13.Count != 0 || XIAa14.Count != 0 || XIAb1.Count != 0 || XIAb2.Count != 0 || XIAb3.Count != 0)
            {
                Label XIAosszNevLabel = new Label();
                XIAosszNevLabel.Content = "XIA. Lelkészek javadalmai és közterhei összesen:";
                XIAosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                XIAosszNevLabel.Height = 27;
                XIAosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIAosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(XIAosszNevLabel);

                Label XIAosszErtekLabel = new Label();
                XIAosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                XIAosszErtekLabel.Height = 27;
                XIAosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIAosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                XIAosszErtekLabel.Content = XIAaosszeg + XIAbosszeg;
                myGrid.Children.Add(XIAosszErtekLabel);
                m += 30;
            }           

            //folabel
            Label XIBaLabel = new Label();
            XIBaLabel.Content = "XIBa. Javadalmak";
            XIBaLabel.Margin = new Thickness(0, m, 0, 0);
            XIBaLabel.Height = 27;
            m += 27;
            XIBaLabel.HorizontalAlignment = HorizontalAlignment.Left;
            XIBaLabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(XIBaLabel);

            generateAll(XIBa1, XIBaLista, 0, 8);
            generateAll(XIBa2, XIBaLista, 1, 8);
            generateAll(XIBa3, XIBaLista, 3, 8);
            generateAll(XIBa4, XIBaLista, 3, 8);
            generateAll(XIBa5, XIBaLista, 4, 8);
            generateAll(XIBa6, XIBaLista, 5, 8);
            generateAll(XIBa7, XIBaLista, 6, 8);
            generateAll(XIBa8, XIBaLista, 7, 8);
            generateAll(XIBa9, XIBaLista, 8, 8);
            generateAll(XIBa10, XIBaLista, 9, 8);

            if (XIBa1.Count != 0 || XIBa2.Count != 0 || XIBa3.Count != 0 || XIBa4.Count != 0 || XIBa5.Count != 0 || XIBa6.Count != 0 || XIBa7.Count != 0 || XIBa8.Count != 0 || XIBa9.Count != 0 || XIBa10.Count != 0 )
            {
                Label XIBaosszNevLabel = new Label();
                XIBaosszNevLabel.Content = "XIBa. Javadalmak összesen:";
                XIBaosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                XIBaosszNevLabel.Height = 27;
                XIBaosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIBaosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(XIBaosszNevLabel);

                Label XIBaosszErtekLabel = new Label();
                XIBaosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                XIBaosszErtekLabel.Height = 27;
                XIBaosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIBaosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                XIBaosszErtekLabel.Content = XIBaosszeg;
                myGrid.Children.Add(XIBaosszErtekLabel);
                m += 30;
            }

            //folabel
            Label XIBbLabel = new Label();
            XIBbLabel.Content = "XIBb. Közterhek";
            XIBbLabel.Margin = new Thickness(0, m, 0, 0);
            XIBbLabel.Height = 27;
            m += 27;
            XIBbLabel.HorizontalAlignment = HorizontalAlignment.Left;
            XIBbLabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(XIBbLabel);

            generateAll(XIBb1, XIBbLista, 0, 9);
            generateAll(XIBb2, XIBbLista, 1, 9);
            generateAll(XIBb3, XIBbLista, 2, 9);

            if (XIBb1.Count != 0 || XIBb2.Count != 0 || XIBb3.Count != 0)
            {
                Label XIBbosszNevLabel = new Label();
                XIBbosszNevLabel.Content = "XIBb. Közterhek összesen:";
                XIBbosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                XIBbosszNevLabel.Height = 27;
                XIBbosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIBbosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(XIBbosszNevLabel);

                Label XIBbosszErtekLabel = new Label();
                XIBbosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                XIBbosszErtekLabel.Height = 27;
                XIBbosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIBbosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                XIBbosszErtekLabel.Content = XIBbosszeg;
                myGrid.Children.Add(XIBbosszErtekLabel);
                m += 30;
            }

            if (XIBa1.Count != 0 || XIBa2.Count != 0 || XIBa3.Count != 0 || XIBa4.Count != 0 || XIBa5.Count != 0 || XIBa6.Count != 0 || XIBa7.Count != 0 || XIBa8.Count != 0 || XIBa9.Count != 0 || XIBa10.Count != 0 || XIBb1.Count != 0 || XIBb2.Count != 0 || XIBb3.Count != 0)
            {
                Label XIBosszNevLabel = new Label();
                XIBosszNevLabel.Content = "XIB. Alkalmazottak javadalmai és közterhei összesen:";
                XIBosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                XIBosszNevLabel.Height = 27;
                XIBosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIBosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(XIBosszNevLabel);

                Label XIBosszErtekLabel = new Label();
                XIBosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                XIBosszErtekLabel.Height = 27;
                XIBosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIBosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                XIBosszErtekLabel.Content = XIBaosszeg + XIBbosszeg;
                myGrid.Children.Add(XIBosszErtekLabel);
                m += 30;
            }

            if (XIAaosszeg != 0 || XIAbosszeg != 0 || XIBaosszeg != 0 || XIBbosszeg != 0)
            {
                Label XIosszNevLabel = new Label();
                XIosszNevLabel.Content = "XI. Alkalmazottak javadalmai és közterhei összesen:";
                XIosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                XIosszNevLabel.Height = 27;
                XIosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(XIosszNevLabel);

                Label XIosszErtekLabel = new Label();
                XIosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                XIosszErtekLabel.Height = 27;
                XIosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                XIosszErtekLabel.Content = XIAaosszeg + XIAbosszeg + XIBaosszeg + XIBbosszeg;
                myGrid.Children.Add(XIosszErtekLabel);
                m += 30;
            }

            //folabel
            Label XIILabel = new Label();
            XIILabel.Content = "XII. Gyülekezeti élet kiadásai";
            XIILabel.Margin = new Thickness(0, m, 0, 0);
            XIILabel.Height = 27;
            m += 27;
            XIILabel.HorizontalAlignment = HorizontalAlignment.Left;
            XIILabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(XIILabel);

            generateAll(XII1, XIILista, 0, 10);
            generateAll(XII2, XIILista, 1, 10);
            generateAll(XII3, XIILista, 3, 10);
            generateAll(XII4, XIILista, 3, 10);
            generateAll(XII5, XIILista, 4, 10);
            generateAll(XII6, XIILista, 5, 10);
            generateAll(XII7, XIILista, 6, 10);
            generateAll(XII8, XIILista, 7, 10);
            generateAll(XII9, XIILista, 8, 10);
            generateAll(XII10, XIILista, 9, 10);
            generateAll(XII11, XIILista, 10, 10);
            generateAll(XII12, XIILista, 11, 10);
            generateAll(XII13, XIILista, 12, 10);
            generateAll(XII14, XIILista, 13, 10);

            if (XII1.Count != 0 || XII2.Count != 0 || XII3.Count != 0 || XII4.Count != 0 || XII5.Count != 0 || XII6.Count != 0 || XII7.Count != 0 || XII8.Count != 0 || XII9.Count != 0 || XII10.Count != 0 || XII11.Count != 0 || XII12.Count != 0 || XII13.Count != 0 || XII14.Count != 0)
            {
                Label XIIosszNevLabel = new Label();
                XIIosszNevLabel.Content = "XII. Gyülekezeti élet kiadásai összesen:";
                XIIosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                XIIosszNevLabel.Height = 27;
                XIIosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIIosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(XIIosszNevLabel);

                Label XIIosszErtekLabel = new Label();
                XIIosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                XIIosszErtekLabel.Height = 27;
                XIIosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIIosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                XIIosszErtekLabel.Content = XIIosszeg;
                myGrid.Children.Add(XIIosszErtekLabel);
                m += 30;
            }

            //folabel
            Label XIIILabel = new Label();
            XIIILabel.Content = "XIII. Igazgatási kiadások";
            XIIILabel.Margin = new Thickness(0, m, 0, 0);
            XIIILabel.Height = 27;
            m += 27;
            XIIILabel.HorizontalAlignment = HorizontalAlignment.Left;
            XIIILabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(XIIILabel);

            generateAll(XIII1, XIIILista, 0, 11);
            generateAll(XIII2, XIIILista, 1, 11);
            generateAll(XIII3, XIIILista, 3, 11);
            generateAll(XIII4, XIIILista, 3, 11);
            generateAll(XIII5, XIIILista, 4, 11);
            generateAll(XIII6, XIIILista, 5, 11);
            generateAll(XIII7, XIIILista, 6, 11);
            generateAll(XIII8, XIIILista, 7, 11);
            generateAll(XIII9, XIIILista, 8, 11);
            generateAll(XIII10, XIIILista, 9, 11);
            generateAll(XIII11, XIIILista, 10, 11);
            generateAll(XIII12, XIIILista, 11, 11);
            generateAll(XIII13, XIIILista, 12, 11);
            generateAll(XIII14, XIIILista, 13, 11);
            generateAll(XIII15, XIIILista, 14, 11);

            if (XIII1.Count != 0 || XIII2.Count != 0 || XIII3.Count != 0 || XIII4.Count != 0 || XIII5.Count != 0 || XIII6.Count != 0 || XIII7.Count != 0 || XIII8.Count != 0 || XIII9.Count != 0 || XIII10.Count != 0 || XIII11.Count != 0 || XIII12.Count != 0 || XIII13.Count != 0 || XIII14.Count != 0 || XIII15.Count != 0)
            {
                Label XIIIosszNevLabel = new Label();
                XIIIosszNevLabel.Content = "XIII. Igazgatási kiadások összesen:";
                XIIIosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                XIIIosszNevLabel.Height = 27;
                XIIIosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIIIosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(XIIIosszNevLabel);

                Label XIIIosszErtekLabel = new Label();
                XIIIosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                XIIIosszErtekLabel.Height = 27;
                XIIIosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIIIosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                XIIIosszErtekLabel.Content = XIIIosszeg;
                myGrid.Children.Add(XIIIosszErtekLabel);
                m += 30;
            }

            //folabel
            Label XIVLabel = new Label();
            XIVLabel.Content = "XIV. Egyházi ingatlanok és bérlemények fenntartása";
            XIVLabel.Margin = new Thickness(0, m, 0, 0);
            XIVLabel.Height = 27;
            m += 27;
            XIVLabel.HorizontalAlignment = HorizontalAlignment.Left;
            XIVLabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(XIVLabel);

            generateAll(XIV1, XIVLista, 0, 12);
            generateAll(XIV2, XIVLista, 1, 12);
            generateAll(XIV3, XIVLista, 3, 12);
            generateAll(XIV4, XIVLista, 3, 12);
            generateAll(XIV5, XIVLista, 4, 12);
            generateAll(XIV6, XIVLista, 5, 12);
            generateAll(XIV7, XIVLista, 6, 12);
            generateAll(XIV8, XIVLista, 7, 12);
            generateAll(XIV9, XIVLista, 8, 12);
            generateAll(XIV10, XIVLista, 9, 12);
            generateAll(XIV11, XIVLista, 10, 12);
            generateAll(XIV12, XIVLista, 11, 12);
            generateAll(XIV13, XIVLista, 12, 12);
            generateAll(XIV14, XIVLista, 13, 12);


            if (XIV1.Count != 0 || XIV2.Count != 0 || XIV3.Count != 0 || XIV4.Count != 0 || XIV5.Count != 0 || XIV6.Count != 0 || XIV7.Count != 0 || XIV8.Count != 0 || XIV9.Count != 0 || XIV10.Count != 0 || XIV11.Count != 0 || XIV12.Count != 0 || XIV13.Count != 0 || XIV14.Count != 0)
            {
                Label XIVosszNevLabel = new Label();
                XIVosszNevLabel.Content = "XIV. Egyházi ingatlanok és bérlemények fenntartása összesen:";
                XIVosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                XIVosszNevLabel.Height = 27;
                XIVosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIVosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(XIVosszNevLabel);

                Label XIVosszErtekLabel = new Label();
                XIVosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                XIVosszErtekLabel.Height = 27;
                XIVosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XIVosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                XIVosszErtekLabel.Content = XIVosszeg;
                myGrid.Children.Add(XIVosszErtekLabel);
                m += 30;
            }

            //folabel
            Label XVLabel = new Label();
            XVLabel.Content = "XV. Egyházi ingatlanok és bérlemények felújítási és beruházási költségei";
            XVLabel.Margin = new Thickness(0, m, 0, 0);
            XVLabel.Height = 27;
            m += 27;
            XVLabel.HorizontalAlignment = HorizontalAlignment.Left;
            XVLabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(XVLabel);

            generateAll(XV1, XVLista, 0, 13);
            generateAll(XV2, XVLista, 1, 13);
            generateAll(XV3, XVLista, 3, 13);
            generateAll(XV4, XVLista, 3, 13);
            generateAll(XV5, XVLista, 4, 13);
            generateAll(XV6, XVLista, 5, 13);
            generateAll(XV7, XVLista, 6, 13);

            if (XV1.Count != 0 || XV2.Count != 0 || XV3.Count != 0 || XV4.Count != 0 || XV5.Count != 0 || XV6.Count != 0 || XV7.Count != 0 )
            {
                Label XVosszNevLabel = new Label();
                XVosszNevLabel.Content = "XV. Egyházi ingatlanok és bérlemények felújítási és beruházási költségei összesen:";
                XVosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                XVosszNevLabel.Height = 27;
                XVosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XVosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(XVosszNevLabel);

                Label XVosszErtekLabel = new Label();
                XVosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                XVosszErtekLabel.Height = 27;
                XVosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XVosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                XVosszErtekLabel.Content = XVosszeg;
                myGrid.Children.Add(XVosszErtekLabel);
                m += 30;
            }

            //folabel
            Label XVILabel = new Label();
            XVILabel.Content = "XVI. Közalapi hozzájárulás";
            XVILabel.Margin = new Thickness(0, m, 0, 0);
            XVILabel.Height = 27;
            m += 27;
            XVILabel.HorizontalAlignment = HorizontalAlignment.Left;
            XVILabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(XVILabel);

            generateAll(XVI, XVILista, 0, 14);

            if (XVI.Count != 0)
            {
                Label XVIosszNevLabel = new Label();
                XVIosszNevLabel.Content = "XVI. Közalapi hozzájárulások összesen:";
                XVIosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                XVIosszNevLabel.Height = 27;
                XVIosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XVIosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(XVIosszNevLabel);

                Label XVIosszErtekLabel = new Label();
                XVIosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                XVIosszErtekLabel.Height = 27;
                XVIosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XVIosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                XVIosszErtekLabel.Content = XVIosszeg;
                myGrid.Children.Add(XVIosszErtekLabel);
                m += 30;
            }

            //folabel
            Label XVIILabel = new Label();
            XVIILabel.Content = "XVII. Egyéb kiadások";
            XVIILabel.Margin = new Thickness(0, m, 0, 0);
            XVIILabel.Height = 27;
            m += 27;
            XVIILabel.HorizontalAlignment = HorizontalAlignment.Left;
            XVIILabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(XVIILabel);

            generateAll(XVII1, XVIILista, 0, 15);
            generateAll(XVII1a, XVIILista, 1, 15);
            generateAll(XVII1b, XVIILista, 2, 15);
            generateAll(XVII2, XVIILista, 3, 15);
            generateAll(XVII3, XVIILista, 4, 15);
            generateAll(XVII4, XVIILista, 5, 15);
            generateAll(XVII5, XVIILista, 6, 15);
            generateAll(XVII6, XVIILista, 7, 15);

            if (XVII1.Count != 0 || XVII1a.Count != 0 || XVII1b.Count != 0 || XVII2.Count != 0 || XVII3.Count != 0 || XVII4.Count != 0 || XVII5.Count != 0 || XVII6.Count != 0 )
            {
                Label XVIIosszNevLabel = new Label();
                XVIIosszNevLabel.Content = "XVII. Egyéb kiadások összesen:";
                XVIIosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                XVIIosszNevLabel.Height = 27;
                XVIIosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XVIIosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(XVIIosszNevLabel);

                Label XVIIosszErtekLabel = new Label();
                XVIIosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                XVIIosszErtekLabel.Height = 27;
                XVIIosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XVIIosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                XVIIosszErtekLabel.Content = XVIIosszeg;
                myGrid.Children.Add(XVIIosszErtekLabel);
                m += 30;
            }

            //össes saját kiadás label
            Label osszSajatKiadasNevLabel = new Label();
            osszSajatKiadasNevLabel.Content = "Az egyházközség " + year + ". évi saját kiadásai összesen:";
            osszSajatKiadasNevLabel.Margin = new Thickness(0, m, 0, 0);
            osszSajatKiadasNevLabel.Height = 27;
            osszSajatKiadasNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
            osszSajatKiadasNevLabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(osszSajatKiadasNevLabel);

            Label osszSajatKiadasErtekLabel = new Label();
            osszSajatKiadasErtekLabel.Margin = new Thickness(449, m, 0, 0);
            osszSajatKiadasErtekLabel.Height = 27;
            osszSajatKiadasErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
            osszSajatKiadasErtekLabel.VerticalAlignment = VerticalAlignment.Top;
            osszSajatKiadasErtekLabel.Content = XIAaosszeg + XIAbosszeg + XIBaosszeg + XIBbosszeg + XIIosszeg + XIIIosszeg + XIVosszeg + XVosszeg + XVIosszeg + XVIIosszeg;
            myGrid.Children.Add(osszSajatKiadasErtekLabel);
            m += 30;

            //folabel
            Label XVIIILabel = new Label();
            XVIIILabel.Content = "XVIII. Egyéb kiadások";
            XVIIILabel.Margin = new Thickness(0, m, 0, 0);
            XVIIILabel.Height = 27;
            m += 27;
            XVIIILabel.HorizontalAlignment = HorizontalAlignment.Left;
            XVIIILabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(XVIIILabel);

            generateAll(XVIII1, XVIIILista, 0, 16);
            generateAll(XVIII2, XVIIILista, 1, 16);
            generateAll(XVIII3, XVIIILista, 2, 16);
            generateAll(XVIII4, XVIIILista, 3, 16);
            generateAll(XVIII5, XVIIILista, 4, 16);
            generateAll(XVIII6, XVIIILista, 5, 16);

            if (XVIII1.Count != 0 || XVIII2.Count != 0 || XVIII3.Count != 0 || XVIII4.Count != 0 || XVIII5.Count != 0 || XVIII6.Count != 0)
            {
                Label XVIIIosszNevLabel = new Label();
                XVIIIosszNevLabel.Content = "XVIII. Egyéb kiadások összesen:";
                XVIIIosszNevLabel.Margin = new Thickness(0, m, 0, 0);
                XVIIIosszNevLabel.Height = 27;
                XVIIIosszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XVIIIosszNevLabel.VerticalAlignment = VerticalAlignment.Top;
                myGrid.Children.Add(XVIIIosszNevLabel);

                Label XVIIIosszErtekLabel = new Label();
                XVIIIosszErtekLabel.Margin = new Thickness(449, m, 0, 0);
                XVIIIosszErtekLabel.Height = 27;
                XVIIIosszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
                XVIIIosszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
                XVIIIosszErtekLabel.Content = XVIIIosszeg;
                myGrid.Children.Add(XVIIIosszErtekLabel);
                m += 30;
            }

            //összes kiadás label
            Label osszKiadasNevLabel = new Label();
            osszKiadasNevLabel.Content = "Az egyházközség " + year + ". évi kiadásai összesen:";
            osszKiadasNevLabel.Margin = new Thickness(0, m, 0, 0);
            osszKiadasNevLabel.Height = 27;
            osszKiadasNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
            osszKiadasNevLabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(osszKiadasNevLabel);

            Label osszKiadasErtekLabel = new Label();
            osszKiadasErtekLabel.Margin = new Thickness(449, m, 0, 0);
            osszKiadasErtekLabel.Height = 27;
            osszKiadasErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
            osszKiadasErtekLabel.VerticalAlignment = VerticalAlignment.Top;
            osszKiadasErtekLabel.Content = XIAaosszeg + XIAbosszeg + XIBaosszeg + XIBbosszeg + XIIosszeg + XIIIosszeg + XIVosszeg + XVosszeg + XVIosszeg + XVIIosszeg + XVIIIosszeg;
            myGrid.Children.Add(osszKiadasErtekLabel);
            m += 30;

            myGrid.Height = m + 50;

            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right / 2) - (this.Width / 2);
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom / 2) - (this.Height / 2);
        }
    }
}
