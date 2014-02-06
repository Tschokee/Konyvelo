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
        List<Bejegyzés> I, II1, II2, II3, II4, II5, II6, III1, III2, III3, III4, III5, III6, III7, III8, III9, III10, IV1, IV2, IV3, IV4, IV5, IV6, IV7, IV8, IV9, IV10, V1, V2, V3, V4, V5, V6,
            XIAa1, XIAa2, XIAa3, XIAa4, XIAa5, XIAa6, XIAa7, XIAa8, XIAa9, XIAa10, XIAa11, XIAa12, XIAa13, XIAa14, XIAb1, XIAb2, XIAb3, XIBa1, XIBa2, XIBa3, XIBa4, XIBa5, XIBa6, XIBa7, XIBa8, XIBa9, XIBa10,
            XIBb1, XIBb2, XIBb3, XII1, XII2, XII3, XII4, XII5, XII6, XII7, XII8, XII9, XII10, XII11, XII12, XII13, XII14, XIII1, XIII2, XIII3, XIII4, XIII5, XIII6, XIII7, XIII8, XIII9, XIII10, XIII11, XIII12, XIII13, XIII14, XIII15,
            XIV1, XIV2, XIV3, XIV4, XIV5, XIV6, XIV7, XIV8, XIV9, XIV10, XIV11, XIV12, XIV13, XIV14, XV1, XV2, XV3, XV4, XV5, XV6, XV7, XVI, XVII1, XVII2, XVII3, XVII4, XVII5, XVII6, XVIII1, XVIII2, XVIII3, XVIII4, XVIII5, XVIII6;
        public FokonyvWindow(List<Bejegyzés> bl)
        {
            InitializeComponent();

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

            /*DataGrid d = new DataGrid();
            d.Height = 200;
            d.Width = 905;
            d.Margin = new Thickness(0, 100, 0, 0);*/
            
            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right / 2) - (this.Width / 2);
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom / 2) - (this.Height / 2);
        }
    }
}
