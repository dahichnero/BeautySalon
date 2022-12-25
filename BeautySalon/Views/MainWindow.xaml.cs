using BeautySalon.Models;
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

namespace BeautySalon.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public Service Service { get; }
        public bool IsAdmin { get; private set; }
        public MainWindow(bool isAdmin)
        {
            InitializeComponent();
            IsAdmin = isAdmin;
            if (!isAdmin)
            {
                firstGridColumn.IsEnabled = false;
                firstGridColumn.Width = new GridLength(0);
                WindowStyle = WindowStyle.None;
                ResizeMode = ResizeMode.NoResize;
                WindowState = WindowState.Maximized;
                mainFrame.Navigate(new ServicesPages(isAdmin));
            }
        }

        private void navigateToServices(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ServicesPages(IsAdmin));
        }

        private void navigateToRegist(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ZapPage(IsAdmin));
        }
    }
}
