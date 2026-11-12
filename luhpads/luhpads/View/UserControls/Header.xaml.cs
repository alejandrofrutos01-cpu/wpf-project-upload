using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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

namespace luhpads.View.UserControls
{
    /// <summary>
    /// Lógica de interacción para Header.xaml
    /// </summary>
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();

        }

        

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            App.Inicio.Show();
            App.Inicio.Focus();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
        
            App.Galeria.Show();
            App.Galeria.Focus();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Login.Show();
            App.Login.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Inicio.Show();
            App.Inicio.Focus();
        }
    }
}
