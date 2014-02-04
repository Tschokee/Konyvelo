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
            I.Add(new PénzMozgás("I", "Egyházfenntartói járulékok"));

            return I;
        }

        List<PénzMozgás> II = new List<PénzMozgás>();
        private List<PénzMozgás> IILista()
        {
            II.Add(new PénzMozgás("II", "1", "Gyülekezeti (templomi) perselypénzek"));
            II.Add(new PénzMozgás("II", "2", "Nem templomi perselypénzek"));
            II.Add(new PénzMozgás("II", "3", "Szórványok"));

            return II;
        }

        List<PénzMozgás> III = new List<PénzMozgás>();
        private List<PénzMozgás> IIILista()
        {
            III.Add(new PénzMozgás("III", "1","Isten dicsőségére"));
            III.Add(new PénzMozgás("III", "2", "Úrvacsorai jegyekre"));
            III.Add(new PénzMozgás("III", "3", "Legátumokra"));
            III.Add(new PénzMozgás("III", "4", "Céladományok"));
            III.Add(new PénzMozgás("III", "5", "Céladományok"));
            III.Add(new PénzMozgás("III", "6", "Céladományok"));
            III.Add(new PénzMozgás("III", "7", "Céladományok"));
            III.Add(new PénzMozgás("III", "8", "Stólamegváltás"));
            III.Add(new PénzMozgás("III", "9", "Áldozati adományok"));

            return III;
        }

        List<PénzMozgás> IV = new List<PénzMozgás>();
        private List<PénzMozgás> IVLista()
        {
            IV.Add(new PénzMozgás("IV", "1", "Térítések alkalmazottaktól"));
            IV.Add(new PénzMozgás("IV", "2", "Ingatlanok (temető stb.) bevétele"));
            IV.Add(new PénzMozgás("IV", "3", "Iratterjesztés"));
            IV.Add(new PénzMozgás("IV", "4", "Gyülekezeti ház bevételei"));
            IV.Add(new PénzMozgás("IV", "5", "Hitoktatás"));
            IV.Add(new PénzMozgás("IV", "6", "Támogatások, kölcsönök"));
            IV.Add(new PénzMozgás("IV", "7", "Vegyes és előre nem látható bevétel"));
            IV.Add(new PénzMozgás("IV", "8", "2014. évi pénztári maradvány"));
            IV.Add(new PénzMozgás("IV", "9", "Átmenő tétel"));
            IV.Add(new PénzMozgás("IV", "10", "Pénzforgalom"));

            return IV;
        }
        
        List<PénzMozgás> V = new List<PénzMozgás>();
        private List<PénzMozgás> VLista()
        {
            V.Add(new PénzMozgás("V", "1", "Állami normatíva"));
            V.Add(new PénzMozgás("V", "2", "Kiegészítő állami támogatás"));
            V.Add(new PénzMozgás("V", "3", "Pályázati céltámogatások átadása"));

            return V;
        }

        List<PénzMozgás> XIAa = new List<PénzMozgás>();
        private List<PénzMozgás> XIAaLista()
        {
            XIAa.Add(new PénzMozgás("XI", "A", "a", "1", "Leklész helyi javadalma"));
            XIAa.Add(new PénzMozgás("XI", "A", "a", "2", "Leklész helyi javadalma"));
            XIAa.Add(new PénzMozgás("XI", "A", "a", "3", "Leklész helyi javadalma"));
            XIAa.Add(new PénzMozgás("XI", "A", "a", "4", "Leklész helyi javadalma"));
            XIAa.Add(new PénzMozgás("XI", "A", "a", "5", "Leklész helyi javadalma"));
            XIAa.Add(new PénzMozgás("XI", "A", "a", "6", "Segédlekész javadalma"));
            XIAa.Add(new PénzMozgás("XI", "A", "a", "7", "Segédlekész javadalma"));
            XIAa.Add(new PénzMozgás("XI", "A", "a", "8", "Fűtés világítás javadalmi része"));
            XIAa.Add(new PénzMozgás("XI", "A", "a", "10", "Helyettesítések munkabérei"));
            XIAa.Add(new PénzMozgás("XI", "A", "a", "11", "Természetbeni javadalmak ellenértéke"));
            XIAa.Add(new PénzMozgás("XI", "A", "a", "12", "Kárpótlékok"));
            XIAa.Add(new PénzMozgás("XI", "A", "a", "13", "Stóla"));
            XIAa.Add(new PénzMozgás("XI", "A", "a", "14", "Javadalmak nyugdíjintézeti tagsági járuléka(i)"));

            return XIAa;
        }

        List<PénzMozgás> XIAb = new List<PénzMozgás>();
        private List<PénzMozgás> XIAbLista()
        {
            XIAb.Add(new PénzMozgás("XI", "A", "b", "15", "Javadalmak nyugdíjintézeti fenntartói járuléka(i)"));
            XIAb.Add(new PénzMozgás("XI", "A", "b", "16", "Adóelőlegek"));

            return XIAb;
        }
        List<PénzMozgás> XIBa = new List<PénzMozgás>();
        private List<PénzMozgás> XIBaLista()
        {
            XIBa.Add(new PénzMozgás("XI", "B", "a", "1", "Irodai alkalmazott(ak) illetménye"));
            XIBa.Add(new PénzMozgás("XI", "B", "a", "2", "Kántor (orgonista) illetménye"));
            XIBa.Add(new PénzMozgás("XI", "B", "a", "3", "Egyházfi illetménye"));
            XIBa.Add(new PénzMozgás("XI", "B", "a", "4", "Harangozó illetménye"));
            XIBa.Add(new PénzMozgás("XI", "B", "a", "5", "Egyházfenntartói járulékszedők jutaléka"));
            XIBa.Add(new PénzMozgás("XI", "B", "a", "8", "Munkabérjellegű egyéb kifizetések"));
            XIBa.Add(new PénzMozgás("XI", "B", "a", "10", "Alkalmazottak javadalmának járulékai"));

            return XIBa;
        }

        List<PénzMozgás> XIBb = new List<PénzMozgás>();
        private List<PénzMozgás> XIBbLista()
        {
            XIBb.Add(new PénzMozgás("XI", "B", "b", "11", "Alkalmazottak javadalmának közterhei"));

            return XIBb;
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
            MyDataGrid.ItemsSource = bejegyzések;
            MyDataGrid.IsReadOnly = true;
            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right / 2) - (this.Width / 2);
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom / 2) - (this.Height / 2);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window cw = new ChoiceWindow(bejegyzések, MyDataGrid, ILista(), IILista(), IIILista(), IVLista(), VLista(), XIAaLista(), XIAbLista(), XIBaLista(), XIBbLista());
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
            if (bejegyzések.Count() != 0 && t != -1 && t <= bejegyzések.Count() - 1)
            {
                Window CDW = new ComfirmDeleteWindow(bejegyzések, MyDataGrid);
                CDW.Show();
            }
        }

        private void zaroszamButton_Click(object sender, RoutedEventArgs e)
        {
            Window ZSZW = new ZaroszamadasWindow();
            ZSZW.Show();
        }

        private void koltsegvetesButton_Click(object sender, RoutedEventArgs e)
        {
            Window KW = new KoltsegvetesWindow(ILista(), IILista(), IIILista(), IVLista());
            KW.Show();
        }

        private void fokonyvButton_Click(object sender, RoutedEventArgs e)
        {
            Window FW = new FokonyvWindow();
            FW.Show();
        }

    }
}
