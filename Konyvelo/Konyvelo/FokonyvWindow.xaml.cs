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
        List<Bejegyzés> I = new List<Bejegyzés>(), II1 = new List<Bejegyzés>(), II2 = new List<Bejegyzés>(), II3 = new List<Bejegyzés>(), II4 = new List<Bejegyzés>(), II5 = new List<Bejegyzés>(), II6 = new List<Bejegyzés>(), III1 = new List<Bejegyzés>(), III2 = new List<Bejegyzés>(), III3 = new List<Bejegyzés>(), III4 = new List<Bejegyzés>(), III5 = new List<Bejegyzés>(), III6 = new List<Bejegyzés>(), III7 = new List<Bejegyzés>(), III8 = new List<Bejegyzés>(), III9 = new List<Bejegyzés>(), III10 = new List<Bejegyzés>(), IV1 = new List<Bejegyzés>(), IV2 = new List<Bejegyzés>(), IV3 = new List<Bejegyzés>(), IV4 = new List<Bejegyzés>(), IV5 = new List<Bejegyzés>(), IV6 = new List<Bejegyzés>(), IV7 = new List<Bejegyzés>(), IV8 = new List<Bejegyzés>(), IV9 = new List<Bejegyzés>(), IV10 = new List<Bejegyzés>(), V1 = new List<Bejegyzés>(), V2 = new List<Bejegyzés>(), V3 = new List<Bejegyzés>(), V4 = new List<Bejegyzés>(), V5 = new List<Bejegyzés>(), V6 = new List<Bejegyzés>(),
            XIAa1 = new List<Bejegyzés>(), XIAa2 = new List<Bejegyzés>(), XIAa3 = new List<Bejegyzés>(), XIAa4 = new List<Bejegyzés>(), XIAa5 = new List<Bejegyzés>(), XIAa6 = new List<Bejegyzés>(), XIAa7 = new List<Bejegyzés>(), XIAa8 = new List<Bejegyzés>(), XIAa9 = new List<Bejegyzés>(), XIAa10 = new List<Bejegyzés>(), XIAa11 = new List<Bejegyzés>(), XIAa12 = new List<Bejegyzés>(), XIAa13 = new List<Bejegyzés>(), XIAa14 = new List<Bejegyzés>(), XIAb1 = new List<Bejegyzés>(), XIAb2 = new List<Bejegyzés>(), XIAb3 = new List<Bejegyzés>(), XIBa1 = new List<Bejegyzés>(), XIBa2 = new List<Bejegyzés>(), XIBa3 = new List<Bejegyzés>(), XIBa4 = new List<Bejegyzés>(), XIBa5 = new List<Bejegyzés>(), XIBa6 = new List<Bejegyzés>(), XIBa7 = new List<Bejegyzés>(), XIBa8 = new List<Bejegyzés>(), XIBa9 = new List<Bejegyzés>(), XIBa10 = new List<Bejegyzés>(),
            XIBb1 = new List<Bejegyzés>(), XIBb2 = new List<Bejegyzés>(), XIBb3 = new List<Bejegyzés>(), XII1 = new List<Bejegyzés>(), XII2 = new List<Bejegyzés>(), XII3 = new List<Bejegyzés>(), XII4 = new List<Bejegyzés>(), XII5 = new List<Bejegyzés>(), XII6 = new List<Bejegyzés>(), XII7 = new List<Bejegyzés>(), XII8 = new List<Bejegyzés>(), XII9 = new List<Bejegyzés>(), XII10 = new List<Bejegyzés>(), XII11 = new List<Bejegyzés>(), XII12 = new List<Bejegyzés>(), XII13 = new List<Bejegyzés>(), XII14 = new List<Bejegyzés>(), XIII1 = new List<Bejegyzés>(), XIII2 = new List<Bejegyzés>(), XIII3 = new List<Bejegyzés>(), XIII4 = new List<Bejegyzés>(), XIII5 = new List<Bejegyzés>(), XIII6 = new List<Bejegyzés>(), XIII7 = new List<Bejegyzés>(), XIII8 = new List<Bejegyzés>(), XIII9 = new List<Bejegyzés>(), XIII10 = new List<Bejegyzés>(), XIII11 = new List<Bejegyzés>(), XIII12 = new List<Bejegyzés>(), XIII13 = new List<Bejegyzés>(), XIII14 = new List<Bejegyzés>(), XIII15 = new List<Bejegyzés>(),
            XIV1 = new List<Bejegyzés>(), XIV2 = new List<Bejegyzés>(), XIV3 = new List<Bejegyzés>(), XIV4 = new List<Bejegyzés>(), XIV5 = new List<Bejegyzés>(), XIV6 = new List<Bejegyzés>(), XIV7 = new List<Bejegyzés>(), XIV8 = new List<Bejegyzés>(), XIV9 = new List<Bejegyzés>(), XIV10 = new List<Bejegyzés>(), XIV11 = new List<Bejegyzés>(), XIV12 = new List<Bejegyzés>(), XIV13 = new List<Bejegyzés>(), XIV14 = new List<Bejegyzés>(), XV1 = new List<Bejegyzés>(), XV2 = new List<Bejegyzés>(), XV3 = new List<Bejegyzés>(), XV4 = new List<Bejegyzés>(), XV5 = new List<Bejegyzés>(), XV6 = new List<Bejegyzés>(), XV7 = new List<Bejegyzés>(), XVI = new List<Bejegyzés>(), XVII1 = new List<Bejegyzés>(), XVII2 = new List<Bejegyzés>(), XVII3 = new List<Bejegyzés>(), XVII4 = new List<Bejegyzés>(), XVII5 = new List<Bejegyzés>(), XVII6 = new List<Bejegyzés>(), XVIII1 = new List<Bejegyzés>(), XVIII2 = new List<Bejegyzés>(), XVIII3 = new List<Bejegyzés>(), XVIII4 = new List<Bejegyzés>(), XVIII5 = new List<Bejegyzés>(), XVIII6 = new List<Bejegyzés>();
        double m = 0;
        private void listakNullaz()
        {
            I = new List<Bejegyzés>(); II1 = new List<Bejegyzés>(); II2 = new List<Bejegyzés>(); II3 = new List<Bejegyzés>(); II4 = new List<Bejegyzés>(); II5 = new List<Bejegyzés>(); II6 = new List<Bejegyzés>(); III1 = new List<Bejegyzés>(); III2 = new List<Bejegyzés>(); III3 = new List<Bejegyzés>(); III4 = new List<Bejegyzés>(); III5 = new List<Bejegyzés>(); III6 = new List<Bejegyzés>(); III7 = new List<Bejegyzés>(); III8 = new List<Bejegyzés>(); III9 = new List<Bejegyzés>(); III10 = new List<Bejegyzés>(); IV1 = new List<Bejegyzés>(); IV2 = new List<Bejegyzés>(); IV3 = new List<Bejegyzés>(); IV4 = new List<Bejegyzés>(); IV5 = new List<Bejegyzés>(); IV6 = new List<Bejegyzés>(); IV7 = new List<Bejegyzés>(); IV8 = new List<Bejegyzés>(); IV9 = new List<Bejegyzés>(); IV10 = new List<Bejegyzés>(); V1 = new List<Bejegyzés>(); V2 = new List<Bejegyzés>(); V3 = new List<Bejegyzés>(); V4 = new List<Bejegyzés>(); V5 = new List<Bejegyzés>(); V6 = new List<Bejegyzés>();
            XIAa1 = new List<Bejegyzés>(); XIAa2 = new List<Bejegyzés>(); XIAa3 = new List<Bejegyzés>(); XIAa4 = new List<Bejegyzés>(); XIAa5 = new List<Bejegyzés>(); XIAa6 = new List<Bejegyzés>(); XIAa7 = new List<Bejegyzés>(); XIAa8 = new List<Bejegyzés>(); XIAa9 = new List<Bejegyzés>(); XIAa10 = new List<Bejegyzés>(); XIAa11 = new List<Bejegyzés>(); XIAa12 = new List<Bejegyzés>(); XIAa13 = new List<Bejegyzés>(); XIAa14 = new List<Bejegyzés>(); XIAb1 = new List<Bejegyzés>(); XIAb2 = new List<Bejegyzés>(); XIAb3 = new List<Bejegyzés>(); XIBa1 = new List<Bejegyzés>(); XIBa2 = new List<Bejegyzés>(); XIBa3 = new List<Bejegyzés>(); XIBa4 = new List<Bejegyzés>(); XIBa5 = new List<Bejegyzés>(); XIBa6 = new List<Bejegyzés>(); XIBa7 = new List<Bejegyzés>(); XIBa8 = new List<Bejegyzés>(); XIBa9 = new List<Bejegyzés>(); XIBa10 = new List<Bejegyzés>();
            XIBb1 = new List<Bejegyzés>(); XIBb2 = new List<Bejegyzés>(); XIBb3 = new List<Bejegyzés>(); XII1 = new List<Bejegyzés>(); XII2 = new List<Bejegyzés>(); XII3 = new List<Bejegyzés>(); XII4 = new List<Bejegyzés>(); XII5 = new List<Bejegyzés>(); XII6 = new List<Bejegyzés>(); XII7 = new List<Bejegyzés>(); XII8 = new List<Bejegyzés>(); XII9 = new List<Bejegyzés>(); XII10 = new List<Bejegyzés>(); XII11 = new List<Bejegyzés>(); XII12 = new List<Bejegyzés>(); XII13 = new List<Bejegyzés>(); XII14 = new List<Bejegyzés>(); XIII1 = new List<Bejegyzés>(); XIII2 = new List<Bejegyzés>(); XIII3 = new List<Bejegyzés>(); XIII4 = new List<Bejegyzés>(); XIII5 = new List<Bejegyzés>(); XIII6 = new List<Bejegyzés>(); XIII7 = new List<Bejegyzés>(); XIII8 = new List<Bejegyzés>(); XIII9 = new List<Bejegyzés>(); XIII10 = new List<Bejegyzés>(); XIII11 = new List<Bejegyzés>(); XIII12 = new List<Bejegyzés>(); XIII13 = new List<Bejegyzés>(); XIII14 = new List<Bejegyzés>(); XIII15 = new List<Bejegyzés>();
            XIV1 = new List<Bejegyzés>(); XIV2 = new List<Bejegyzés>(); XIV3 = new List<Bejegyzés>(); XIV4 = new List<Bejegyzés>(); XIV5 = new List<Bejegyzés>(); XIV6 = new List<Bejegyzés>(); XIV7 = new List<Bejegyzés>(); XIV8 = new List<Bejegyzés>(); XIV9 = new List<Bejegyzés>(); XIV10 = new List<Bejegyzés>(); XIV11 = new List<Bejegyzés>(); XIV12 = new List<Bejegyzés>(); XIV13 = new List<Bejegyzés>(); XIV14 = new List<Bejegyzés>(); XV1 = new List<Bejegyzés>(); XV2 = new List<Bejegyzés>(); XV3 = new List<Bejegyzés>(); XV4 = new List<Bejegyzés>(); XV5 = new List<Bejegyzés>(); XV6 = new List<Bejegyzés>(); XV7 = new List<Bejegyzés>(); XVI = new List<Bejegyzés>(); XVII1 = new List<Bejegyzés>(); XVII2 = new List<Bejegyzés>(); XVII3 = new List<Bejegyzés>(); XVII4 = new List<Bejegyzés>(); XVII5 = new List<Bejegyzés>(); XVII6 = new List<Bejegyzés>(); XVIII1 = new List<Bejegyzés>(); XVIII2 = new List<Bejegyzés>(); XVIII3 = new List<Bejegyzés>(); XVIII4 = new List<Bejegyzés>(); XVIII5 = new List<Bejegyzés>(); XVIII6 = new List<Bejegyzés>();
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
                    case 16: XVIIosszeg += Convert.ToInt32(blosszErtekLabel.Content); break;
                    case 17: XVIIIosszeg += Convert.ToInt32(blosszErtekLabel.Content); break;
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
            myGrid.Height = bl.Count * 30;
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
                    case "XIAa/1": XIAa1.Add(b); break;
                    case "XIAa/2": XIAa2.Add(b); break;
                    case "XIAa/3": XIAa3.Add(b); break;
                    case "XIAa/4": XIAa4.Add(b); break;
                    case "XIAa/5": XIAa5.Add(b); break;
                    case "XIAa/6": XIAa6.Add(b); break;
                    case "XIAa/7": XIAa7.Add(b); break;
                    case "XIAa/8": XIAa8.Add(b); break;
                    case "XIAa/9": XIAa9.Add(b); break;
                    case "XIAa/10": XIAa10.Add(b); break;
                    case "XIAa/11": XIAa11.Add(b); break;
                    case "XIAa/12": XIAa12.Add(b); break;
                    case "XIAa/13": XIAa13.Add(b); break;
                    case "XIAa/14": XIAa14.Add(b); break;
                    case "XIAb/1": XIAb1.Add(b); break;
                    case "XIAb/2": XIAb2.Add(b); break;
                    case "XIAb/3": XIAb3.Add(b); break;
                    case "XIBa/1": XIBa1.Add(b); break;
                    case "XIBa/2": XIBa2.Add(b); break;
                    case "XIBa/3": XIBa3.Add(b); break;
                    case "XIBa/4": XIBa4.Add(b); break;
                    case "XIBa/5": XIBa5.Add(b); break;
                    case "XIBa/6": XIBa6.Add(b); break;
                    case "XIBa/7": XIBa7.Add(b); break;
                    case "XIBa/8": XIBa8.Add(b); break;
                    case "XIBa/9": XIBa9.Add(b); break;
                    case "XIBa/10": XIBa10.Add(b); break;
                    case "XIBb/1": XIBb1.Add(b); break;
                    case "XIBb/2": XIBb2.Add(b); break;
                    case "XIBb/3": XIBb3.Add(b); break;
                    case "XII/1": XII1.Add(b); break;
                    case "XII/2": XII2.Add(b); break;
                    case "XII/3": XII3.Add(b); break;
                    case "XII/4": XII4.Add(b); break;
                    case "XII/5": XII5.Add(b); break;
                    case "XII/6": XII6.Add(b); break;
                    case "XII/7": XII7.Add(b); break;
                    case "XII/8": XII8.Add(b); break;
                    case "XII/9": XII9.Add(b); break;
                    case "XII/10": XII10.Add(b); break;
                    case "XII/11": XII11.Add(b); break;
                    case "XII/12": XII12.Add(b); break;
                    case "XII/13": XII13.Add(b); break;
                    case "XII/14": XII14.Add(b); break;
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
            Label osszSajatNevLabel = new Label();
            osszSajatNevLabel.Content = "Az egyházközség " + System.DateTime.Now.Year + ". évi saját bevételei összesen:";
            osszSajatNevLabel.Margin = new Thickness(0, m, 0, 0);
            osszSajatNevLabel.Height = 27;
            osszSajatNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
            osszSajatNevLabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(osszSajatNevLabel);

            Label osszSajatErtekLabel = new Label();
            osszSajatErtekLabel.Margin = new Thickness(449, m, 0, 0);
            osszSajatErtekLabel.Height = 27;
            osszSajatErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
            osszSajatErtekLabel.VerticalAlignment = VerticalAlignment.Top;
            osszSajatErtekLabel.Content = Iosszeg + IIosszeg + IIIosszeg + IVosszeg;
            myGrid.Children.Add(osszSajatErtekLabel);
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
            Label osszNevLabel = new Label();
            osszNevLabel.Content = "Az egyházközség " + System.DateTime.Now.Year + ". évi bevételei összesen:";
            osszNevLabel.Margin = new Thickness(0, m, 0, 0);
            osszNevLabel.Height = 27;
            osszNevLabel.HorizontalAlignment = HorizontalAlignment.Left;
            osszNevLabel.VerticalAlignment = VerticalAlignment.Top;
            myGrid.Children.Add(osszNevLabel);

            Label osszErtekLabel = new Label();
            osszErtekLabel.Margin = new Thickness(449, m, 0, 0);
            osszErtekLabel.Height = 27;
            osszErtekLabel.HorizontalAlignment = HorizontalAlignment.Left;
            osszErtekLabel.VerticalAlignment = VerticalAlignment.Top;
            osszErtekLabel.Content = Iosszeg + IIosszeg + IIIosszeg + IVosszeg + Vosszeg;
            myGrid.Children.Add(osszErtekLabel);
            m += 30;

            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right / 2) - (this.Width / 2);
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom / 2) - (this.Height / 2);
        }
    }
}
