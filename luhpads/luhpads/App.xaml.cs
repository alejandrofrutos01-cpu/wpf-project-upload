using System.Configuration;
using System.Data;
using System.Windows;

namespace luhpads
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Window1 Galeria { get; private set; }
        public static MainWindow Inicio { get; private set; }
        public static Window2 Login { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Galeria = new Window1();
            Inicio = new MainWindow();
            Login = new Window2();

            Inicio.Show();
        }
        

        
    }
}
