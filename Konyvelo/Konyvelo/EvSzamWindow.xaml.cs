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
    /// Interaction logic for EvSzamWindow.xaml
    /// </summary>
    public partial class EvSzamWindow : Window
    {
        public EvSzamWindow()
        {
            InitializeComponent();
            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right / 2) - (this.Width / 2);
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom - (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom / 2) - (this.Height / 2);
        }

        private void Beallit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ész.Text.Length != 0)
                {
                    PénzMozgás.évSzám = Convert.ToInt32(ész.Text);
                    this.Close();
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Az érték mezőbe számot kell megadni!", "Hiba");
            }
        }
    }
}
