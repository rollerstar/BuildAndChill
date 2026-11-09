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

namespace BuildAndChill
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // MenuItems
        // File
        private void Preferences(object sender, RoutedEventArgs e) { /* Show Preferences Window */}
        private void Settings(object sender, RoutedEventArgs e) { /* Show Settings Window */}
        private void Exit(object sender, RoutedEventArgs e) { App.Current.Shutdown(); }

        // Edit
        private void Undo(object sender, RoutedEventArgs e) { }
        private void Redo(object sender, RoutedEventArgs e) { /* Show Preferences Window */}


        // Profiles

        // Help
        private void About(object sender, RoutedEventArgs e) { /* Show About Window */}
            }
}