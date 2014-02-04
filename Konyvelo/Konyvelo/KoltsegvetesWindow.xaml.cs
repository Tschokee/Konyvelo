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
    /// Interaction logic for KoltsegvetesWindow.xaml
    /// </summary>
    public partial class KoltsegvetesWindow : Window
    {
        List<PénzMozgás> pénzmozgások;
        //List<String> ls;
        public KoltsegvetesWindow(List<PénzMozgás> p)
        {
            InitializeComponent();
            this.pénzmozgások = p;

            /*DataGridTextColumn col1 = new DataGridTextColumn();
            col1.Header = "asd";
            string s;
            foreach (PénzMozgás penz in p)
            {
                s = penz.azonosító;
                if (penz.azonosítóMásodikSzint != null)
                {
                    s = s + "/" + penz.azonosítóMásodikSzint;
                    if (penz.azonosítóHarmadikSzint != null)
                    {
                        s = s + "/" + penz.azonosítóHarmadikSzint;
                        if (penz.azonosítóNegyedikSzint != null)
                            s = s + "/" + penz.azonosítóNegyedikSzint;
                    }
                }
                s = s + " " + penz.név;
                col1.Binding = new Binding(s);
            }
            MyDataGrid.Columns.Add(col1);*/

            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right / 2) - (this.Width / 2);
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom / 2) - (this.Height / 2);
        }
    }
}
