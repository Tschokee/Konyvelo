using System;
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
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.Win32;
using System.Linq.Expressions;
using System.Reflection;

namespace Konyvelo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Bejegyzés> bejegyzések = new List<Bejegyzés>();
        List<List<PénzMozgás>> listaz = new List<List<PénzMozgás>>();
        Dictionary<string, List<Bejegyzés>> fokonyv = new Dictionary<string, List<Bejegyzés>>(); 
        
        public string ReturnFokonyvRomaiSzam(Bejegyzés bejegyzes) {
            //na ez ittlehet  hülyeség de benne hagyom mert még lehet jó
            foreach (List<PénzMozgás> lista in listaz)
            {
                foreach (PénzMozgás p in lista)
                {
                    if (bejegyzes.főkönyv==p.azonosító)
                    {
                        return p.név;
                    }
                }   
            }
            return "";
        }
        public static string Givemeaprostring(PénzMozgás b){
        
        string[] temp;
        string t="";
            temp=b.azonosító.Split('/');
            t += temp[0];
            for (int i = 1; i < temp.Length-1; i++)
			{
                t += '/'; t += temp[i];
			}
          
          
        return t;
        }
        private static string megnevezesfromromai(string rsz)
        {
            return ""; // ide lehete kiegészíteni a római szúmokat megnevezéssel(pl. :ha rsz==II akkor return Perselypénzek ===> sok if= én nem írom végig
        }
        public static string ReturnFokonyvRomaiSzam(PénzMozgás pénzmMozgás)
        {
            return pénzmMozgás.azonosító.Split('/')[0] + megnevezesfromromai(pénzmMozgás.azonosító.Split('/')[0]);
        }
        private List<Bejegyzés> LoadCollectionData()
        {
            bejegyzések.Add(new Bejegyzés(1, "2014. jan. 1.", "Maradvány 2008-ról (házipénztár)", "IV/10", 4093002, 0, 0, 0, "BeB/2014"));
            bejegyzések.Add(new Bejegyzés(2, "2014. jan. 1.", "Maradvány 2008-ról (bankszámla)", "IV/10", 0, 0, 110000, 0, "664-0184"));
            bejegyzések.Add(new Bejegyzés(3, "2014. jan. 7.", "Postaköltség", "XVIII/2", 0, 0, 0, 5000, "KiP/2014"));
            bejegyzések.Add(new Bejegyzés(4, "2014. jan. 8.", "Óévi perselyadomány", "XVII/1", 12000, 0, 0, 0, "KiB/2014"));

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
            III.Add(new PénzMozgás("III/1", "Isten dicsőségére"));
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
            IV.Add(new PénzMozgás("IV/10", "Pénzforgalom"));//27

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
            V.Add(new PénzMozgás("V/6", ""));//33

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
            XII.Add(new PénzMozgás("XII/9", ""));//45

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
            XIII.Add(new PénzMozgás("XIII/15", ""));//50

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
            XIV.Add(new PénzMozgás("XIV/14", ""));//64

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
            XV.Add(new PénzMozgás("XV/7", ""));//71

            return XV;
        }

        List<PénzMozgás> XVI = new List<PénzMozgás>();
        private List<PénzMozgás> XVILista()
        {
            XVI.Clear();
            XVI.Add(new PénzMozgás("XVI", "Közalapi hozzájárulás"));//72

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
            XVII.Add(new PénzMozgás("XVII/6", "Vegyes és előre nem látható kiadások"));//78

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
            XVIII.Add(new PénzMozgás("XVIII/6", ""));//86

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

        private void listazo()
        {
            listaz.Add(I);
            listaz.Add(II);
            listaz.Add(III);
            listaz.Add(IV);
            listaz.Add(V);
            listaz.Add(XIAa);
            listaz.Add(XIAb);
            listaz.Add(XIBa);
            listaz.Add(XIBb);
            listaz.Add(XII);
            listaz.Add(XIII);
            listaz.Add(XIV);
            listaz.Add(XIV);
            listaz.Add(XV);
            listaz.Add(XVI);
            listaz.Add(XVII);
            listaz.Add(XVIII);
        }

        public MainWindow()
        {
            InitializeComponent();
            loadFokonyv();
            listazo();
            //MyDataGrid.ItemsSource = LoadCollectionData(); ///LoadCFromFile(PénzMozgás.évSzám.ToString());bejegyzések listát feltöltő metódus
            //SaveTo(PénzMozgás.évSzám.ToString());
            MyDataGrid.IsReadOnly = true;
            //generateLists();//ha a pénzmozgás tábla üres akkor kell csak lefuttatni ezt a metódust és elmenteni a táblába, ha nem üres akkor a táblából kell betölteni az adatokat a listákba
            MyDataGrid.AutoGenerateColumns = false;
            MyDataGrid.CanUserSortColumns = false;
            DataGridTextColumn col1 = new DataGridTextColumn();
            col1.Binding = new Binding("sorSzám");
            col1.Header = "Sorszám";
            col1.Width = 55;
            MyDataGrid.Columns.Add(col1);
            DataGridTextColumn col2 = new DataGridTextColumn();
            col2.Binding = new Binding("fizetésIdeje");
            col2.Header = "Fizetés ideje";
            col2.Width = 87;
            MyDataGrid.Columns.Add(col2);
            DataGridTextColumn col3 = new DataGridTextColumn();
            col3.Binding = new Binding("megjegyzés");
            col3.Header = "Megjegyzés";
            col3.Width = 221;
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
            col7.Width = 95;
            MyDataGrid.Columns.Add(col7);
            DataGridTextColumn col8 = new DataGridTextColumn();
            col8.Binding = new Binding("pénztáriBevétel");
            col8.Header = "Pénztári bevétel";
            col8.Width = 95;
            MyDataGrid.Columns.Add(col8);
            DataGridTextColumn col9 = new DataGridTextColumn();
            col9.Binding = new Binding("pénztáriKiadás");
            col9.Header = "Pénztár kiadás";
            col9.Width = 87;
            MyDataGrid.Columns.Add(col9);
            DataGridTextColumn col10 = new DataGridTextColumn();
            col10.Binding = new Binding("pénztáriEgyenleg");
            col10.Header = "Pénztári egyenleg";
            col10.Width = 105;
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
            Window FW = new FokonyvWindow(bejegyzések, I, II, III, IV, V, XIAa, XIAb, XIBa, XIBb, XII, XIII, XIV, XV, XVI, XVII, XVIII);
            FW.Show();
        }

        private void sugoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Window SW = new SugoWindow();
            SW.Show();
        }

        private void evSzamMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Window EW = new EvSzamWindow();
            EW.Show();
        }

        private void printMenuItem_Click(object sender, RoutedEventArgs e)
        {
            /*  PrintDialog dlg = new PrintDialog();
              dlg.ShowDialog();
              //dlg.PrintVisual(MyDataGrid, "Oldal nyomtatás");

              Size pageSize = new Size(dlg.PrintableAreaWidth, dlg.PrintableAreaHeight);
              // sizing of the element.
              MyDataGrid.Measure(pageSize);
              MyDataGrid.Arrange(new Rect(5, 5, pageSize.Width, pageSize.Height));
              dlg.PrintVisual(MyDataGrid, Title);*/
            Image myImage = new Image();
            RenderTargetBitmap bitmap = new RenderTargetBitmap(900, 900, 96, 96, PixelFormats.Pbgra32);
            bitmap.Render(MyDataGrid);
            myImage.Source = bitmap;
            StackPanel myStackPanel = new StackPanel();
            myStackPanel.Children.Add(myImage);
            this.Content = myStackPanel;
        }

        public void SaveFokonyv()
        {
            try
            {
                using (Stream stream = File.Open("fokonyv.bdb", FileMode.Create))
                {
                    List<PénzMozgás> lp = new List<PénzMozgás>();
                    BinaryFormatter bin = new BinaryFormatter();
                    foreach (PénzMozgás p in I)
                        lp.Add(p);
                    foreach (PénzMozgás p in II)
                        lp.Add(p);
                    foreach (PénzMozgás p in III)
                        lp.Add(p);
                    foreach (PénzMozgás p in IV)
                        lp.Add(p);
                    foreach (PénzMozgás p in V)
                        lp.Add(p);
                    foreach (PénzMozgás p in XIAa)
                        lp.Add(p);
                    foreach (PénzMozgás p in XIAb)
                        lp.Add(p);
                    foreach (PénzMozgás p in XIBa)
                        lp.Add(p);
                    foreach (PénzMozgás p in XIBb)
                        lp.Add(p);
                    foreach (PénzMozgás p in XII)
                        lp.Add(p);
                    foreach (PénzMozgás p in XIII)
                        lp.Add(p);
                    foreach (PénzMozgás p in XIV)
                        lp.Add(p);
                    foreach (PénzMozgás p in XV)
                        lp.Add(p);
                    foreach (PénzMozgás p in XVI)
                        lp.Add(p);
                    foreach (PénzMozgás p in XVII)
                        lp.Add(p);
                    foreach (PénzMozgás p in XVIII)
                        lp.Add(p);
                    bin.Serialize(stream, lp);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void SaveTo(string fileName)
        {
            try
            {
                using (Stream stream = File.Open(fileName + ".bdb", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, bejegyzések);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private List<Bejegyzés> LoadCFromFile(string filename)
        {
            bejegyzések = new List<Bejegyzés>();
            try
            {
                using (Stream stream = File.Open(filename, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    bejegyzések = (List<Bejegyzés>)bin.Deserialize(stream);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }

            return bejegyzések;
        }

        private void loadFokonyv()
        {
            List<PénzMozgás> lp = new List<PénzMozgás>();
            int i = 0;
            try
            {
                using (Stream stream = File.Open("fokonyv.bdb", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    lp = (List<PénzMozgás>)bin.Deserialize(stream);
                    I.Add(lp[0]);
                    for (i = 1; i < 7; i++)
                        II.Add(lp[i]);
                    for (; i < 17; i++)
                        III.Add(lp[i]);
                    for (; i < 27; i++)
                        IV.Add(lp[i]);
                    for (; i < 33; i++)
                        V.Add(lp[i]);
                    for (; i < 47; i++)
                        XIAa.Add(lp[i]);
                    for (; i < 50; i++)
                        XIAb.Add(lp[i]);
                    for (; i < 60; i++)
                        XIBa.Add(lp[i]);
                    for (; i < 63; i++)
                        XIBb.Add(lp[i]);
                    for (; i < 77; i++)
                        XII.Add(lp[i]);
                    for (; i < 92; i++)
                        XIII.Add(lp[i]);
                    for (; i < 106; i++)
                        XIV.Add(lp[i]);
                    for (; i < 113; i++)
                        XV.Add(lp[i]);
                    for (; i < 114; i++)
                        XVI.Add(lp[i]);
                    for (; i < 122; i++)
                        XVII.Add(lp[i]);
                    for (; i < 128; i++)
                        XVIII.Add(lp[i]);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public string CreatePrintPage()
        {
            string filename = "print.html";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false, Encoding.Unicode))
            {

                file.Write("<html><head><title>Napló</title></head><body>");
                if (bejegyzések.Count > 18)
                {
                    file.Write("<table border=1px height=\"950\"><tr><th rowspan=3></th><th rowspan=3>Fizetés ideje</th><th rowspan=3 width=\"250\">Megnevezés</th><th rowspan=3>Főkönyv</th><th colspan=3>Banki forgalom</th><th colspan=3>Pénztári forgalom</th></tr>");

                }
                else
                {

                    file.Write("<table border=1px><tr><th rowspan=3></th><th rowspan=3>Fizetés ideje</th><th rowspan=3 width=\"250\">Megnevezés</th><th rowspan=3>Főkönyv</th><th colspan=3>Banki forgalom</th><th colspan=3>Pénztári forgalom</th></tr>");

                }
                file.Write("<tr><th>Bevétel</th><th>Kiadás</th><th rowspan=2>Egyenleg</th><th>Bevétel</th><th>Kiadás</th><th rowspan=2>Egyenleg</th></tr><tr><th>Forint</th><th>Forint</th><th>Forint</th><th>Forint</th></tr>");
                int i = 0;
                Bejegyzés szamlalo = new Bejegyzés();
                szamlalo.bankiBevétel = 0;
                szamlalo.bankiEgyenleg = 0;
                szamlalo.bankiKiadás = 0;
                szamlalo.pénztáriBevétel = 0;
                szamlalo.pénztáriEgyenleg = 0;
                szamlalo.pénztáriKiadás = 0;
                int limit = 19;
                int sorszamolo = 0;
                foreach (Bejegyzés bejegyzes in bejegyzések)
                {
                    sorszamolo++;
                    i++;
                    if (i < limit)
                    {
                        file.Write(bejegyzes.toTableString());

                    }
                    else
                    {
                        if (limit == 19)
                        {
                            limit = 17;
                        }
                        file.Write("<tr><td colspan=4 align=\"right\">Átvitel:</td><td>" + szamlalo.bankiBevétel + "</td><td>" + szamlalo.bankiKiadás + "</td><td>" + szamlalo.bankiEgyenleg + "</td><td>" + szamlalo.pénztáriBevétel + "</td><td>" + szamlalo.pénztáriKiadás + "</td><td>" + szamlalo.pénztáriEgyenleg + "</td></tr></table><br/>");
                        if (bejegyzések.Count - sorszamolo > limit)
                        {
                            file.Write("<table border=1px height=\"950\"><tr><th rowspan=3></th><th rowspan=3>Fizetés ideje</th><th rowspan=3 width=\"250\">Megnevezés</th><th rowspan=3>Főkönyv</th><th colspan=3>Banki forgalom</th><th colspan=3>Pénztári forgalom</th></tr>");

                        }
                        else
                        {
                            file.Write("<table border=1px><tr><th rowspan=3></th><th rowspan=3>Fizetés ideje</th><th rowspan=3 width=\"250\">Megnevezés</th><th rowspan=3>Főkönyv</th><th colspan=3>Banki forgalom</th><th colspan=3>Pénztári forgalom</th></tr>");

                        }
                        file.Write("<tr><th>Bevétel</th><th>Kiadás</th><th rowspan=2>Egyenleg</th><th>Bevétel</th><th>Kiadás</th><th rowspan=2>Egyenleg</th></tr><tr><th>Forint</th><th>Forint</th><th>Forint</th><th>Forint</th></tr>");
                        file.Write("<tr><td colspan=4 align=\"right\">Áthozat:</td><td>" + szamlalo.bankiBevétel + "</td><td>" + szamlalo.bankiKiadás + "</td><td>" + szamlalo.bankiEgyenleg + "</td><td>" + szamlalo.pénztáriBevétel + "</td><td>" + szamlalo.pénztáriKiadás + "</td><td>" + szamlalo.pénztáriEgyenleg + "</td></tr>");

                        file.Write(bejegyzes.toTableString());
                        i = 0;
                    }
                    szamlalo.bankiBevétel += bejegyzes.bankiBevétel;
                    szamlalo.bankiKiadás += bejegyzes.bankiKiadás;
                    szamlalo.bankiEgyenleg += bejegyzes.bankiEgyenleg;
                    szamlalo.pénztáriBevétel += bejegyzes.pénztáriBevétel;
                    szamlalo.pénztáriEgyenleg += bejegyzes.pénztáriEgyenleg;
                    szamlalo.pénztáriKiadás += bejegyzes.pénztáriKiadás;

                }
                if (i != 0)
                {
                    file.Write("<tr><td colspan=4 align=\"right\">Átvitel:</td><td>" + szamlalo.bankiBevétel + "</td><td>" + szamlalo.bankiKiadás + "</td><td>" + szamlalo.bankiEgyenleg + "</td><td>" + szamlalo.pénztáriBevétel + "</td><td>" + szamlalo.pénztáriKiadás + "</td><td>" + szamlalo.pénztáriEgyenleg + "</td></tr></table>");
                }
                file.Write("</body></html>");
            }

            return filename;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //generateLists();
            CreatePrintPageZaro("2014");
            CreatePrintPage();
            CreatePrintPagekolt("2014");
            createOrganizedFokonyvfromBejegyzesek();
            CreatePrintPageFokonyv("2014");
        }
        public bool testcp(int c, int p1, System.IO.StreamWriter file,int sor,string h)
        {
            if (c > sor)
            {
                //c = 0; p1++;
                if (p1 < 5)
                    file.Write("</table><br/><table height=\""+h+"\" border=\"1\"  width=\"900\" style =\"border-collapse:collapse;\">");
                else
                    file.Write("</table><br/><table border=\"1\"  width=\"900\" style =\"border-collapse:collapse;\">");
                return true;
            }
            return false;


        }
    
        public string CreatePrintPageZaro(string year)
        {
            int i;
            /*
                i = 0;
                foreach (List<PénzMozgás> l in listaz)
                {


                    foreach (PénzMozgás p in l)
                    {
                        //p.teljesítés = 0;
                        
                        foreach (Bejegyzés b in bejegyzések)
                        {
                        if (i < 5)
                        {


                            if (b.főkönyv == p.azonosító)
                            {

                             //   p.teljesítés += b.bankiBevétel + b.pénztáriBevétel;
                                break;
                            }
                        }
                        else
                        {
                            if (b.főkönyv == p.azonosító)
                            {

                            //    p.teljesítés += b.bankiKiadás + b.pénztáriKiadás;
                                break;
                            }


                        }
                    }

                    } i++;
            }

            */
            string filename = "printz.html";
            i = 0;
            int c = 0, p1 = 0, egyhazsajatki = 0, egyhazsajatbe = 0;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false, Encoding.Unicode))
            {
                PénzMozgás ossz = new PénzMozgás();
                file.Write("<html><head><title>Zárszámadás</title></head><body><table height=\"1300\" border=\"1\"  width=\"900\" style =\"border-collapse:collapse;\">");
                foreach (List<PénzMozgás> listn in listaz)
                {
                    PénzMozgás temp = new PénzMozgás();

                    file.Write("<tr height=\"45\"><th>" + Givemeaprostring(listn[0]) + "</th><th>Költségvetési Cím</th><th>Előirányzat</th><th>Teljesítés</th></tr>");
                    if (testcp(c++, p1, file,28,"1300"))
                    {
                        c=0;p1++;
                    } 
                    foreach (PénzMozgás penz in listn)
                    {
                        if (testcp(c++, p1, file, 28, "1300"))
                    {
                        c=0;p1++;
                    } 
                        file.Write(penz.ToPString());
                        temp.előirányzat += penz.előirányzat;
                        temp.teljesítés += penz.teljesítés;

                    }

                    file.Write("<tr ><td>&nbsp;</td><td>Összesen:</td><td>" + temp.előirányzat + "</td><td>" + temp.teljesítés + "</td></tr>");
                    if (testcp(c++, p1, file, 28, "1300"))
                    {
                        c=0;p1++;
                    } 
                    file.Write("<tr ><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr>");
                    if (testcp(c++, p1, file, 28, "1300"))
                    {
                        c=0;p1++;
                    } 
                    i++;

                    if (i < 5)
                    {
                        egyhazsajatbe += temp.teljesítés;//direkt van így
                    }
                    if (i >5&&i<17 )
                    {
                        egyhazsajatki += temp.teljesítés;//direkt van így
                    }
                    if (i < 6)
                    {
                        ossz.előirányzat += temp.teljesítés;//direkt van így
                    }
                    else
                    {
                        ossz.teljesítés += temp.teljesítés;//direkt van így
                    }
                }
                file.Write("</table><br/><table border=\"1\"  width=\"900\" style =\"border-collapse:collapse;\">");
                file.Write("<tr height=\"45\"><td>&nbsp;</td><td>Az egyházközség "+ year+". évi saját bevételei összesen</td><td>" + egyhazsajatbe + "</td></tr>");
                file.Write("<tr height=\"45\"><td>&nbsp;</td><td>Az egyházközség " + year + ". évi saját kiadásai összesen</td><td>" + egyhazsajatki + "</td></tr>");
                file.Write("<tr height=\"45\"><td>&nbsp;</td><td>Összes bevétel a " + year + ".évre</td><td>" + ossz.előirányzat + "</td></tr>");
                file.Write("<tr height=\"45\"><td>&nbsp;</td><td>Összes kiadás a " + year + ".évre</td><td>" + ossz.teljesítés + "</td></tr>");
                file.Write("<tr height=\"45\"><td>&nbsp;</td><td>Különbözet</td><td>" + (ossz.előirányzat-ossz.teljesítés) + "</td></tr>");
                file.Write("</table></body></html>");
            }

            return filename;
        }
        public string CreatePrintPageFokonyv(string year)
        {
            List<string> romaiszamk = new List<string>(); 
            List<string> leszk = new List<string>();
            /*
                romaiszamk.Add("I");//hápf

                romaiszamk.Add("II");//hápf
                romaiszamk.Add("III");//hápf
                romaiszamk.Add("IV");//hápf
                romaiszamk.Add("V");//hápf
                romaiszamk.Add("V");//hápf
                romaiszamk.Add("X");//hápf
                romaiszamk.Add("XI");//hápf
                romaiszamk.Add("XII");//hápf
                romaiszamk.Add("XIII");//hápf
                romaiszamk.Add("XIV");//hápf
                romaiszamk.Add("XV");//hápf
                romaiszamk.Add("XVI");//hápf
                romaiszamk.Add("XVII");//hápf
                romaiszamk.Add("I");//hápf

                romaiszamk.Add("II");//hápf
                romaiszamk.Add("III");//hápf
                romaiszamk.Add("IV");//hápf
                romaiszamk.Add("V");//hápf
                romaiszamk.Add("V");//hápf
                romaiszamk.Add("X");//hápf
                romaiszamk.Add("XI");//hápf
                romaiszamk.Add("XII");//hápf
                romaiszamk.Add("XIII");//hápf
                romaiszamk.Add("XIV");//hápf
                romaiszamk.Add("XV");//hápf
                romaiszamk.Add("XVI");//hápf
                romaiszamk.Add("XVII");//hápf
              
            */
            foreach (List<PénzMozgás> lista in listaz)
            {
                foreach (PénzMozgás p in lista)
                {
                    romaiszamk.Add(p.azonosító);
                    leszk.Add(p.név);
                }
            }

            string filename = "printf.html";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false, Encoding.Unicode))
            {
                PénzMozgás ossz = new PénzMozgás();
                string h = "1250";
                string h2 = "50";
                int pn = 24;
                int x = bejegyzések.Count;
                x += romaiszamk.Count;
                int y = x % pn;

                file.Write("<html><head><title>Főkönyv</title></head><body><table height=\""+h+"\" border=\"1\"  width=\"900\" style =\"border-collapse:collapse;\">");
                int i = 0, c = 0, p1 = 0;
                int  egyhazsajatbe = 0, egyhazsajatki = 0;
               
                for (int j = 0; j < romaiszamk.Count; j++)
                { 
                    List<Bejegyzés> temp22 = new List<Bejegyzés>();
                    if (fokonyv.TryGetValue(romaiszamk[j], out temp22))
                    {
                        if (temp22.Count > 0)
                        {


                            file.Write("<tr height=\"" + h2 + "\"><th></th><th></th><th>" + romaiszamk[j] + " " + leszk[j] + "</th><th></th></tr>");
                            x--;
                            int temp =  0;

                            if (x < 30)
                            {
                                h = "0";
                            }
                            if (testcp(c++, p1, file, pn, h))
                            {
                                c = 0; p1++;
                            }

                            if (fokonyv.TryGetValue(romaiszamk[j], out temp22))
                            {
                                foreach (Bejegyzés b2 in temp22)
                                {


                                    file.Write(b2.toTable2String()); x--;
                                    if (x < 30)
                                    {
                                        h = "0";
                                    }
                                    temp += b2.pénztáriBevétel + b2.pénztáriKiadás + b2.bankiKiadás + b2.bankiBevétel;
                                    if (testcp(c++, p1, file, pn, h))
                                    {
                                        c = 0; p1++;
                                    }


                                }
                            }
                            file.Write("<tr height=\"" + h2 + "\" ><td>&nbsp;</td><td>&nbsp;</td><td>Összesen:</td><td>" + temp + "</td></tr>"); x--;
                            if (testcp(c++, p1, file, pn, h))
                            {
                                c = 0; p1++;
                            }
                            if (x < 30)
                            {
                                h = "0";
                            }
                            file.Write("<tr height=\"" + h2 + "\" ><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr>"); x--;
                            if (testcp(c++, p1, file, pn, h))
                            {
                                c = 0; p1++;
                            }
                           


                            if (j < 28)
                            {
                                egyhazsajatbe += temp;//direkt van így
                            }
                            if (j > 27 && j < 34)
                            {
                                egyhazsajatki += temp;//direkt van így
                            }
                            if (j < 34)
                            {
                                ossz.előirányzat += temp;//direkt van így
                            }
                            else
                            {
                                ossz.teljesítés += temp;//direkt van így
                            }
                        }
                    }
                }
                
                file.Write("</table><br/>");
                if (y<5)
                {
                    for (int q = 0; q < y; q++)
                    {
                        file.Write("<br/> &nbsp;");
                        file.Write("<br/> &nbsp;");
                        file.Write("<br/> &nbsp;");
                        file.Write("<br/> &nbsp;");
                        file.Write("<br/> &nbsp;");
                        file.Write("<br/> &nbsp;");
                    } 
                 
                }
                file.Write("<table border=\"1\"  width=\"900\" style =\"border-collapse:collapse;\">");
                file.Write("<tr height=\"" + h2 + "\"><td>&nbsp;</td><td>Az egyházközség " + year + ". évi saját bevételei összesen</td><td>" + egyhazsajatbe + "</td></tr>");
                file.Write("<tr height=\"" + h2 + "\"><td>&nbsp;</td><td>Az egyházközség " + year + ". évi saját kiadásai összesen</td><td>" + egyhazsajatki + "</td></tr>");
                file.Write("<tr height=\"" + h2 + "\"><td>&nbsp;</td><td>Összes előirányzott bevétel a " + year + ".évre</td><td>" + ossz.előirányzat + "</td></tr>");
                file.Write("<tr height=\"" + h2 + "\"><td>&nbsp;</td><td>Összes előirányzott kiadás a " + year + ".évre</td><td>" + ossz.teljesítés + "</td></tr>");
                //file.Write("<tr height=\"" + h2 + "\"><td>&nbsp;</td><td>Különbözet</td><td>" + (ossz.előirányzat - ossz.teljesítés) + "</td></tr>");
                file.Write("</table></body></html>");
            } 
            
            return filename;
        }
        public string CreatePrintPagekolt(string year)
        {
            int i;
            string filename = "printk.html";
            i = 0;
            int c = 0, p1 = 0, egyhazsajatki = 0, egyhazsajatbe = 0;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false, Encoding.Unicode))
            {
                PénzMozgás ossz = new PénzMozgás();
                file.Write("<html><head><title>Költségvetés</title></head><body><table height=\"1300\" border=\"1\"  width=\"900\" style =\"border-collapse:collapse;\">");
                foreach (List<PénzMozgás> listn in listaz)
                {
                    PénzMozgás temp = new PénzMozgás();

                    file.Write("<tr height=\"45\"><th>" + listn[0].azonosító + "</th><th>Költségvetési Cím</th><th>Összesen</th></tr>");
                    if (testcp(c++, p1, file, 28, "1300"))
                    {
                        c = 0; p1++;
                    }
                    foreach (PénzMozgás penz in listn)
                    {
                        if (testcp(c++, p1, file, 28, "1300"))
                        {
                            c = 0; p1++;
                        }
                        file.Write(penz.ToP2String());
                        temp.előirányzat += penz.előirányzat;
                        

                    }

                    file.Write("<tr ><td>&nbsp;</td><td>Összesen:</td><td>" + temp.előirányzat + "</td></tr>");
                    if (testcp(c++, p1, file, 28, "1300"))
                    {
                        c = 0; p1++;
                    }
                    file.Write("<tr ><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr>");
                    if (testcp(c++, p1, file, 28, "1300"))
                    {
                        c = 0; p1++;
                    }
                    i++;

                    if (i < 5)
                    {
                        egyhazsajatbe += temp.előirányzat;//direkt van így
                    }
                    if (i > 4 && i < 17)
                    {
                        egyhazsajatki += temp.előirányzat;//direkt van így
                    }
                    if (i < 6)
                    {
                        ossz.előirányzat += temp.előirányzat;//direkt van így
                    }
                    else
                    {
                        ossz.teljesítés += temp.előirányzat;//direkt van így
                    }
                }
                file.Write("</table><br/><table border=\"1\"  width=\"900\" style =\"border-collapse:collapse;\">");
                file.Write("<tr height=\"45\"><td>&nbsp;</td><td>Az egyházközség " + year + ". évi saját bevételei összesen</td><td>" + egyhazsajatbe + "</td></tr>");
                file.Write("<tr height=\"45\"><td>&nbsp;</td><td>Az egyházközség " + year + ". évi saját kiadásai összesen</td><td>" + egyhazsajatki + "</td></tr>");
                file.Write("<tr height=\"45\"><td>&nbsp;</td><td>Összes előirányzott bevétel a " + year + ".évre</td><td>" + ossz.előirányzat + "</td></tr>");
                file.Write("<tr height=\"45\"><td>&nbsp;</td><td>Összes előirányzott kiadás a " + year + ".évre</td><td>" + ossz.teljesítés + "</td></tr>");
                file.Write("<tr height=\"45\"><td>&nbsp;</td><td>Különbözet</td><td>" + (ossz.előirányzat - ossz.teljesítés) + "</td></tr>");
                file.Write("</table></body></html>");
            }

            return filename;
        }

        static string Check<T>(Expression<Func<T>> expr)
        {
            var body = ((MemberExpression)expr.Body);

            return body.Member.Name;
        }

        public void createOrganizedFokonyvfromBejegyzesek() {
            fokonyv = new Dictionary<string, List<Bejegyzés>>();
            foreach (Bejegyzés b in bejegyzések)
            {
                List<Bejegyzés> temp= new List<Bejegyzés>();
                if (!fokonyv.ContainsKey(b.főkönyv))
                {
                    fokonyv.Add(b.főkönyv, new List<Bejegyzés>());
                }
                fokonyv.TryGetValue(b.főkönyv, out temp);
                temp.Add(b);
            }
        
        
        
        
        
        }




        private void mentesClick(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                if (filename.EndsWith(".bdb"))
                {
                    filename = filename.Remove(filename.Length - 4, 4);
                }
                SaveTo(filename);
                SaveFokonyv();
            }

        }

        private void loadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                LoadCFromFile(filename);
                //loadFokonyv();
                MyDataGrid.ItemsSource = bejegyzések;
                MyDataGrid.Items.Refresh();
            }
        }
    }
}
