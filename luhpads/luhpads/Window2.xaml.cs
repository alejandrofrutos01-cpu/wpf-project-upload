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
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
        }

        private void Usuario_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(Usuario.Text))
            {
                PlaceHold.Visibility = Visibility.Visible;
            }
            else
            {
                PlaceHold.Visibility = Visibility.Hidden;
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (Usuario.Text == "" || Contraseña.Password == "")
            {
                Usuario.Clear();
                Contraseña.Clear();
                MessageBox.Show("Inserte el nombre del usuario o el Password");
                Usuario.Focus();
                return;
            }
            else
            {

                if (Usuario.Text != "Alumno" || Contraseña.Password != "1234")
                {
                    MessageBox.Show("El nombre de usuario o el password es incorrecto");
                    Usuario.Clear();
                    Contraseña.Clear();
                    Usuario.Focus();
                    return;
                }
                else
                    Usuario.Clear();
                Contraseña.Clear();
                MessageBox.Show("Usuario correcto");
                App.Inicio.Show();
                App.Inicio.Focus();
                return;
            }
        }

        private void Contraseña_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Contraseña.Password))
            {
                Placehold2.Visibility = Visibility.Visible;
            }
            else
            {
                Placehold2.Visibility = Visibility.Hidden;
            }
        }
    }
}
