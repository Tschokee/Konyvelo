﻿using System;
using System.Collections.Generic;
using System.Collections;
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

        //ez a metódus tölti be a bejegyzések táblából az adatokat a listába
        private List<Bejegyzés> LoadCollectionData()
        {
            bejegyzések.Add(new Bejegyzés(1, "tegnap", "asdfashdl", "I", 1000, 300, 500, 600));
            bejegyzések.Add(new Bejegyzés(2, "tegnap", "asdfashdl", "II/2", 1000, 300, 500, 600));
            bejegyzések.Add(new Bejegyzés(3, "tegnap", "asdfashdl", "I", 200, 600, 1200, 100));

            for (int i = 0; i < 50; i++)
            {
                bejegyzések.Add(new Bejegyzés());
            }

            return bejegyzések;
        }

        List<PénzMozgás> I = new List<PénzMozgás>();
        private List<PénzMozgás> ILista()
        {
            I.Clear();
            I.Add(new PénzMozgás("I", "Egyházfenntartói járulékok"));

            return I;
        }

        List<PénzMozgás> II = new List<PénzMozgás>();
        private List<PénzMozgás> IILista()
        {
            II.Clear();
            II.Add(new PénzMozgás("II/1", "Gyülekezeti (templomi) perselypénzek"));
            II.Add(new PénzMozgás("II/2", "Nem templomi perselypénzek"));
            II.Add(new PénzMozgás("II/3", "Szórványok"));
            II.Add(new PénzMozgás("II/4", ""));
            II.Add(new PénzMozgás("II/5", ""));
            II.Add(new PénzMozgás("II/6", ""));

            return II;
        }

        List<PénzMozgás> III = new List<PénzMozgás>();
        private List<PénzMozgás> IIILista()
        {
            III.Clear();
            III.Add(new PénzMozgás("III/1","Isten dicsőségére"));
            III.Add(new PénzMozgás("III/2", "Úrvacsorai jegyekre"));
            III.Add(new PénzMozgás("III/3", "Legátumokra"));
            III.Add(new PénzMozgás("III/4", "Céladományok"));
            III.Add(new PénzMozgás("III/5", "Céladományok"));
            III.Add(new PénzMozgás("III/6", "Céladományok"));
            III.Add(new PénzMozgás("III/7", "Céladományok"));
            III.Add(new PénzMozgás("III/8", "Stólamegváltás"));
            III.Add(new PénzMozgás("III/9", "Áldozati adományok"));
            III.Add(new PénzMozgás("III/10", ""));

            return III;
        }

        List<PénzMozgás> IV = new List<PénzMozgás>();
        private List<PénzMozgás> IVLista()
        {
            IV.Clear();
            IV.Add(new PénzMozgás("IV/1", "Térítések alkalmazottaktól"));
            IV.Add(new PénzMozgás("IV/2", "Ingatlanok (temető stb.) bevétele"));
            IV.Add(new PénzMozgás("IV/3", "Iratterjesztés"));
            IV.Add(new PénzMozgás("IV/4", "Gyülekezeti ház bevételei"));
            IV.Add(new PénzMozgás("IV/5", "Hitoktatás"));
            IV.Add(new PénzMozgás("IV/6", "Támogatások, kölcsönök"));
            IV.Add(new PénzMozgás("IV/7", "Vegyes és előre nem látható bevétel"));
            IV.Add(new PénzMozgás("IV/8", "2014. évi pénztári maradvány"));
            IV.Add(new PénzMozgás("IV/9", "Átmenő tétel"));
            IV.Add(new PénzMozgás("IV/10", "Pénzforgalom"));

            return IV;
        }
        
        List<PénzMozgás> V = new List<PénzMozgás>();
        private List<PénzMozgás> VLista()
        {
            V.Clear();
            V.Add(new PénzMozgás("V/1", "Állami normatíva"));
            V.Add(new PénzMozgás("V/2", "Kiegészítő állami támogatás"));
            V.Add(new PénzMozgás("V/3", "Pályázati céltámogatások átadása"));
            V.Add(new PénzMozgás("V/4", ""));
            V.Add(new PénzMozgás("V/5", ""));
            V.Add(new PénzMozgás("V/6", ""));

            return V;
        }

        List<PénzMozgás> XIAa = new List<PénzMozgás>();
        private List<PénzMozgás> XIAaLista()
        {
            XIAa.Clear();
            XIAa.Add(new PénzMozgás("XI/A/a/1", "Leklész helyi javadalma"));
            XIAa.Add(new PénzMozgás("XI/A/a/2", "Leklész helyi javadalma"));
            XIAa.Add(new PénzMozgás("XI/A/a/3", "Leklész helyi javadalma"));
            XIAa.Add(new PénzMozgás("XI/A/a/4", "Leklész helyi javadalma"));
            XIAa.Add(new PénzMozgás("XI/A/a/5", "Leklész helyi javadalma"));
            XIAa.Add(new PénzMozgás("XI/A/a/6", "Segédlekész javadalma"));
            XIAa.Add(new PénzMozgás("XI/A/a/7", "Segédlekész javadalma"));
            XIAa.Add(new PénzMozgás("XI/A/a/8", "Fűtés világítás javadalmi része"));
            XIAa.Add(new PénzMozgás("XI/A/a/9", ""));
            XIAa.Add(new PénzMozgás("XI/A/a/10", "Helyettesítések munkabérei"));
            XIAa.Add(new PénzMozgás("XI/A/a/11", "Természetbeni javadalmak ellenértéke"));
            XIAa.Add(new PénzMozgás("XI/A/a/12", "Kárpótlékok"));
            XIAa.Add(new PénzMozgás("XI/A/a/13", "Stóla"));
            XIAa.Add(new PénzMozgás("XI/A/a/14", "Javadalmak nyugdíjintézeti tagsági járuléka(i)"));

            return XIAa;
        }

        List<PénzMozgás> XIAb = new List<PénzMozgás>();
        private List<PénzMozgás> XIAbLista()
        {
            XIAb.Clear();
            XIAb.Add(new PénzMozgás("XI/A/b/15", "Javadalmak nyugdíjintézeti fenntartói járuléka(i)"));
            XIAb.Add(new PénzMozgás("XI/A/b/16", "Adóelőlegek"));
            XIAb.Add(new PénzMozgás("XI/A/b/17", ""));

            return XIAb;
        }
        List<PénzMozgás> XIBa = new List<PénzMozgás>();
        private List<PénzMozgás> XIBaLista()
        {
            XIBa.Clear();
            XIBa.Add(new PénzMozgás("XI/B/a/1", "Irodai alkalmazott(ak) illetménye"));
            XIBa.Add(new PénzMozgás("XI/B/a/2", "Kántor (orgonista) illetménye"));
            XIBa.Add(new PénzMozgás("XI/B/a/3", "Egyházfi illetménye"));
            XIBa.Add(new PénzMozgás("XI/B/a/4", "Harangozó illetménye"));
            XIBa.Add(new PénzMozgás("XI/B/a/5", "Egyházfenntartói járulékszedők jutaléka"));
            XIBa.Add(new PénzMozgás("XI/B/a/6", ""));
            XIBa.Add(new PénzMozgás("XI/B/a/7", ""));
            XIBa.Add(new PénzMozgás("XI/B/a/8", "Munkabérjellegű egyéb kifizetések"));
            XIBa.Add(new PénzMozgás("XI/B/a/9", ""));
            XIBa.Add(new PénzMozgás("XI/B/a/10", "Alkalmazottak javadalmának járulékai"));

            return XIBa;
        }

        List<PénzMozgás> XIBb = new List<PénzMozgás>();
        private List<PénzMozgás> XIBbLista()
        {
            XIBb.Clear();
            XIBb.Add(new PénzMozgás("XI/B/b/11", "Alkalmazottak javadalmának közterhei"));
            XIBb.Add(new PénzMozgás("XI/B/b/12", ""));
            XIBb.Add(new PénzMozgás("XI/B/b/13", ""));

            return XIBb;
        }

        List<PénzMozgás> XII = new List<PénzMozgás>();
        private List<PénzMozgás> XIILista()
        {
            XII.Clear();
            XII.Add(new PénzMozgás("XII/1", "Úrvacsorai jegyekre"));
            XII.Add(new PénzMozgás("XII/2", "Szeretetvendégségek, gyülekezeti napok"));
            XII.Add(new PénzMozgás("XII/3", "Gyülekezeti misszió"));
            XII.Add(new PénzMozgás("XII/3/a", "Konfirmandusok"));
            XII.Add(new PénzMozgás("XII/3/b", "Hitoktatás"));
            XII.Add(new PénzMozgás("XII/3/c", "Ifjúsági munka"));
            XII.Add(new PénzMozgás("XII/3/d", "Szórvány- és tanyagondozás"));
            XII.Add(new PénzMozgás("XII/3/e", "Missziói alkalmak"));
            XII.Add(new PénzMozgás("XII/4", "Legátumok"));
            XII.Add(new PénzMozgás("XII/5", "Gyülekezeten belüli szeretetszolgálat"));
            XII.Add(new PénzMozgás("XII/6", "Gyülekezeti újság"));
            XII.Add(new PénzMozgás("XII/7", "Sajtó misszió"));
            XII.Add(new PénzMozgás("XII/8", ""));
            XII.Add(new PénzMozgás("XII/9", ""));

            return XII;
        }

        List<PénzMozgás> XIII = new List<PénzMozgás>();
        private List<PénzMozgás> XIIILista()
        {
            XIII.Clear();
            XIII.Add(new PénzMozgás("XIII/1", "Irodaszerek"));
            XIII.Add(new PénzMozgás("XIII/2", "Posta- és telefonköltség"));
            XIII.Add(new PénzMozgás("XIII/3", "Banki költségek"));
            XIII.Add(new PénzMozgás("XIII/4", "Egyházi hivatal(ok) fűtése, világítása"));
            XIII.Add(new PénzMozgás("XIII/5", "Egyházközségi hivatal(ok) takarítása"));
            XIII.Add(new PénzMozgás("XIII/6", "Hivatali berendezések és eszközök karbantartása"));
            XIII.Add(new PénzMozgás("XIII/7", "Kiküldetési és közlekedési költségek"));
            XIII.Add(new PénzMozgás("XIII/8", "Gépkocsi fenntartás költségei"));
            XIII.Add(new PénzMozgás("XIII/9", "Egyházlátogatások költségei"));
            XIII.Add(new PénzMozgás("XIII/10", "Újságok előfizetése"));
            XIII.Add(new PénzMozgás("XIII/11", "Egyházközségi könyvtár gyarapítása"));
            XIII.Add(new PénzMozgás("XIII/12", ""));
            XIII.Add(new PénzMozgás("XIII/13", ""));
            XIII.Add(new PénzMozgás("XIII/14", ""));
            XIII.Add(new PénzMozgás("XIII/15", ""));
            
            return XIII;
        }

        List<PénzMozgás> XIV = new List<PénzMozgás>();
        private List<PénzMozgás> XIVLista()
        {
            XIV.Clear();
            XIV.Add(new PénzMozgás("XIV/1", "Templom karbantartási és fenntartási költségei"));
            XIV.Add(new PénzMozgás("XIV/2", "Templom közüzemi költségei"));
            XIV.Add(new PénzMozgás("XIV/3", "Parókia karbantartási és fenntartási költségei"));
            XIV.Add(new PénzMozgás("XIV/4", "Parókia közüzemi költségei"));
            XIV.Add(new PénzMozgás("XIV/5", "Gyülekezeti ház karbantartási és fenntartási költségei"));
            XIV.Add(new PénzMozgás("XIV/6", "Gyülekezeti ház közüzemi költségei"));
            XIV.Add(new PénzMozgás("XIV/7", "Egyéb épület karbantartási és fenntartási költségei"));
            XIV.Add(new PénzMozgás("XIV/8", "Egyéb épület közüzemi költségei"));
            XIV.Add(new PénzMozgás("XIV/9", "Egyéb épület felújitási költségei"));
            XIV.Add(new PénzMozgás("XIV/10", "Egyházi ingatlanok biztosítási díjai"));
            XIV.Add(new PénzMozgás("XIV/11", "Lakbérek"));
            XIV.Add(new PénzMozgás("XIV/12", ""));
            XIV.Add(new PénzMozgás("XIV/13", ""));
            XIV.Add(new PénzMozgás("XIV/14", ""));

            return XIV;
        }

        List<PénzMozgás> XV = new List<PénzMozgás>();
        private List<PénzMozgás> XVLista()
        {
            XV.Clear();
            XV.Add(new PénzMozgás("XV/1", "Templom felújítási költségei"));
            XV.Add(new PénzMozgás("XV/2", "Parókia felújítási költségei"));
            XV.Add(new PénzMozgás("XV/3", "Gyülekezeti ház felújítási költségei"));
            XV.Add(new PénzMozgás("XV/4", "Egyéb épület felújítási költségei"));
            XV.Add(new PénzMozgás("XV/5", ""));
            XV.Add(new PénzMozgás("XV/6", ""));
            XV.Add(new PénzMozgás("XV/7", ""));

            return XV;
        }

        List<PénzMozgás> XVI = new List<PénzMozgás>();
        private List<PénzMozgás> XVILista()
        {
            XVI.Clear();
            XVI.Add(new PénzMozgás("XVI", "Közalapi hozzájárulás"));

            return XVI;
        }

        List<PénzMozgás> XVII = new List<PénzMozgás>();
        private List<PénzMozgás> XVIILista()
        {
            XVII.Clear();
            XVII.Add(new PénzMozgás("XVII/1", "Adományok és segélyek"));
            XVII.Add(new PénzMozgás("XVII/1/a", "Egyházmegyei diakónia"));
            XVII.Add(new PénzMozgás("XVII/1/b", "Lekötött perselypénzek elküldése"));
            XVII.Add(new PénzMozgás("XVII/2", "Kölcsönök törlesztése"));
            XVII.Add(new PénzMozgás("XVII/3", "Gyülekezeten kívűli adományok és segélyek"));
            XVII.Add(new PénzMozgás("XVII/4", "Átmenő tétel"));
            XVII.Add(new PénzMozgás("XVII/5", "Pénzforgalom"));
            XVII.Add(new PénzMozgás("XVII/6", "Vegyes és előre nem látható kiadások"));

            return XVII;
        }

        List<PénzMozgás> XVIII = new List<PénzMozgás>();
        private List<PénzMozgás> XVIIILista()
        {
            XVIII.Clear();
            XVIII.Add(new PénzMozgás("XVIII/1", "Állami normatíva"));
            XVIII.Add(new PénzMozgás("XVIII/2", "Kiegészítő állami támogatás"));
            XVIII.Add(new PénzMozgás("XVIII/3", "Pályázati céltámogatások átadása"));
            XVIII.Add(new PénzMozgás("XVIII/4", ""));
            XVIII.Add(new PénzMozgás("XVIII/5", ""));
            XVIII.Add(new PénzMozgás("XVIII/6", ""));

            return XVIII;
        }

        private void generateLists()
        {
            ILista();
            IILista();
            IIILista();
            IVLista();
            VLista();
            XIAaLista();
            XIAbLista();
            XIBaLista();
            XIBbLista();
            XIILista();
            XIIILista();
            XIVLista();
            XVLista();
            XVILista();
            XVIILista();
            XVIIILista();
        }

        public MainWindow()
        {
            InitializeComponent();
            MyDataGrid.ItemsSource = LoadCollectionData();//bejegyzések listát feltöltő metódus 
            MyDataGrid.IsReadOnly = true;
            generateLists();//ha a pénzmozgás tábla üres akkor kell csak lefuttatni ezt a metódust és elmenteni a táblába, ha nem üres akkor a táblából kell betölteni az adatokat a listákba
            MyDataGrid.AutoGenerateColumns = false;
            DataGridTextColumn col1 = new DataGridTextColumn();
            col1.Binding = new Binding("sorSzám");
            col1.Header = "Sorszám";
            col1.Width = 65;
            MyDataGrid.Columns.Add(col1);
            DataGridTextColumn col2 = new DataGridTextColumn();
            col2.Binding = new Binding("fizetésIdeje");
            col2.Header = "Fizetés ideje";
            col2.Width = 87;
            MyDataGrid.Columns.Add(col2);
            DataGridTextColumn col3 = new DataGridTextColumn();
            col3.Binding = new Binding("megjegyzés");
            col3.Header = "Megjegyzés";
            col3.Width = 87;
            MyDataGrid.Columns.Add(col3);
            DataGridTextColumn col4 = new DataGridTextColumn();
            col4.Binding = new Binding("főkönyv");
            col4.Header = "Főkönyv";
            col4.Width = 80;
            MyDataGrid.Columns.Add(col4);
            DataGridTextColumn col5 = new DataGridTextColumn();
            col5.Binding = new Binding("bankiBevétel");
            col5.Header = "Banki bevétel";
            col5.Width = 87;
            MyDataGrid.Columns.Add(col5);
            DataGridTextColumn col6 = new DataGridTextColumn();
            col6.Binding = new Binding("bankiKiadás");
            col6.Header = "Banki kiadás";
            col6.Width = 87;
            MyDataGrid.Columns.Add(col6);
            DataGridTextColumn col7 = new DataGridTextColumn();
            col7.Binding = new Binding("bankiEgyenleg");
            col7.Header = "Banki egyenleg";
            col7.Width = 87;
            MyDataGrid.Columns.Add(col7);
            DataGridTextColumn col8 = new DataGridTextColumn();
            col8.Binding = new Binding("pénztáriBevétel");
            col8.Header = "Pénztári bevétel";
            col8.Width = 87;
            MyDataGrid.Columns.Add(col8);
            DataGridTextColumn col9 = new DataGridTextColumn();
            col9.Binding = new Binding("pénztáriKiadás");
            col9.Header = "Pénztár kiadás";
            col9.Width = 87;
            MyDataGrid.Columns.Add(col9);
            DataGridTextColumn col10 = new DataGridTextColumn();
            col10.Binding = new Binding("pénztáriEgyenleg");
            col10.Header = "pénztári egyenleg";
            col10.Width = 87;
            MyDataGrid.Columns.Add(col10);
            
            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right / 2) - (this.Width / 2);
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom / 2) - (this.Height / 2);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window cw = new ChoiceWindow(bejegyzések, MyDataGrid, I, II, III, IV, V, XIAa, XIAb, XIBa, XIBb, XII, XIII, XIV, XV, XVI, XVII, XVIII);
            cw.Show();
        }

        private void modositButton_Click(object sender, RoutedEventArgs e)
        {
            int t = Convert.ToInt32(MyDataGrid.SelectedIndex.ToString());
            if (bejegyzések.Count() != 0 && t != -1 && t <= bejegyzések.Count() - 1)
            {
                Window MW = new ModifyWindow(bejegyzések, MyDataGrid, t, I, II, III, IV, V, XIAa, XIAb, XIBa, XIBb, XII, XIII, XIV, XV, XVI, XVII, XVIII);
                MW.Show();
            }
        }

        private void torolButton_Click(object sender, RoutedEventArgs e)
        {
            int t = Convert.ToInt32(MyDataGrid.SelectedIndex.ToString());
            if (bejegyzések.Count() != 0 && t != -1 && t <= bejegyzések.Count() - 1)
            {
                Window CDW = new ComfirmDeleteWindow(bejegyzések, MyDataGrid);
                CDW.Show();
            }
        }

        private void zaroszamButton_Click(object sender, RoutedEventArgs e)
        {
            Window ZSZW = new ZaroszamadasWindow(bejegyzések, I, II, III, IV, V, XIAa, XIAb, XIBa, XIBb, XII, XIII, XIV, XV, XVI, XVII, XVIII);
            ZSZW.Show();
        }

        private void koltsegvetesButton_Click(object sender, RoutedEventArgs e)
        {
            Window KW = new KoltsegvetesWindow(I, II, III, IV, V, XIAa, XIAb, XIBa, XIBb, XII, XIII, XIV, XV, XVI, XVII, XVIII);
            KW.Show();
        }

        private void fokonyvButton_Click(object sender, RoutedEventArgs e)
        {
            Window FW = new FokonyvWindow(bejegyzések);
            FW.Show();
        }

        private void sugoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Window SW = new SugoWindow();
            SW.Show();
        }

        private void printMenuItem_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            dlg.ShowDialog();
            //dlg.PrintVisual(MyDataGrid, "Oldal nyomtatás");

            Size pageSize = new Size(dlg.PrintableAreaWidth, dlg.PrintableAreaHeight);
            // sizing of the element.
            MyDataGrid.Measure(pageSize);
            MyDataGrid.Arrange(new Rect(5, 5, pageSize.Width, pageSize.Height));
            dlg.PrintVisual(MyDataGrid, Title);
        }

    }
}
