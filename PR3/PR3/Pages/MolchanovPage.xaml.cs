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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR3.Pages
{
    /// <summary>
    /// Логика взаимодействия для MolchanovPage.xaml
    /// </summary>
    public partial class MolchanovPage : Page
    {
        public MolchanovPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow win = new NavigationWindow();
            win.Content = new KomovaPage();
            win.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationWindow win = new NavigationWindow();
            win.Content = new OhotnikovPage();
            win.Show();
        }
    }
}
