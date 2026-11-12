using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace luhpads
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {

        }
    }
}
