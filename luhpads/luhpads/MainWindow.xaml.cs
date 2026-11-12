using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace luhpads
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;

            
            
        }
        private void Berserk_MouseEnter(object sender, MouseEventArgs e)
        {
            Berserk.Width = 550;
            BerserkT.FontSize = 58;
        }

        private void Berserk_MouseLeave(object sender, MouseEventArgs e)
        {
            Berserk.Width = 467;
            BerserkT.FontSize = 48;
        }

        private void Negra_MouseEnter(object sender, MouseEventArgs e)
        {
            Negra.Width = 480;
            NegraT.FontSize = 58;
        }

        private void Negra_MouseLeave(object sender, MouseEventArgs e)
        {
            Negra.Width = 467;
            NegraT.FontSize = 48;
        }

        private void Gris_MouseEnter(object sender, MouseEventArgs e)
        {
            Gris.Width = 550;
            GrisT.FontSize = 58;
        }

        private void Gris_MouseLeave(object sender, MouseEventArgs e)
        {
            Gris.Width = 467;
            GrisT.FontSize = 48;
        }

        private void NegraT_MouseEnter(object sender, MouseEventArgs e)
        {
            Negra.Width = 480;
            NegraT.FontSize = 58;
        }

        private void NegraT_MouseLeave(object sender, MouseEventArgs e)
        {
            Negra.Width = 467;
            NegraT.FontSize = 48;
        }

        private void BerserkT_MouseEnter(object sender, MouseEventArgs e)
        {
            Berserk.Width = 550;
            BerserkT.FontSize = 58;
        }

        private void BerserkT_MouseLeave(object sender, MouseEventArgs e)
        {
            Berserk.Width = 467;
            BerserkT.FontSize = 48;
        }

        private void GrisT_MouseEnter(object sender, MouseEventArgs e)
        {
            Gris.Width = 550;
            GrisT.FontSize = 58;
        }

        private void GrisT_MouseLeave(object sender, MouseEventArgs e)
        {
            Gris.Width = 467;
            GrisT.FontSize = 48;
        }
    }
}