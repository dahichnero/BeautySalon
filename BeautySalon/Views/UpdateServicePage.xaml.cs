using BeautySalon.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для UpdateServicePage.xaml
    /// </summary>
    public partial class UpdateServicePage : Page
    {
        public Service Service { get; }
        public List<int> Durations { get; set; } = new();

        public List<double> Discounts { get; set; } = new();

        private List<ServicePhoto> newPhotos = new();
        public UpdateServicePage(Service service)
        {
            Service = service;
            for (int i=15; i<=420; i += 5)
            {
                Durations.Add(i);
            }
            for (int i = 0; i <= 95; i += 5)
            {
                Discounts.Add(i);
            }
            InitializeComponent();
            if (Service.Id == 0)
            {
                headerLabel.Content = "Добавление услуги";
            }
            else
            {
                headerLabel.Content = "Изменение услуги";
                Session.Instance
                    .Context
                    .Services
                    .Entry(service)
                    .Collection(s => s.ServicePhotos).Load();
            }
            // контекст через код:
            DataContext = this;
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            if (Service.Id != 0)
            {
                foreach (var photo in newPhotos)
                {
                    Service.ServicePhotos.Remove(photo);
                }
                Session.Instance.Context.Entry(Service).Reload();
            }
            NavigationService.GoBack();
        }

        private void saveChanges(object sender, RoutedEventArgs e)
        {
            int d = Convert.ToInt32(costservice.Text);
            if (Service.Id == 0 && callservice.Text!="" && d>=500)
            {
                Session.Instance.Context.Add(Service);
                Session.Instance.Context.SaveChanges();
                MessageBox.Show("Данные сохранены.");
                NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("При сохранении данных возникла ошибка!");
                /*if (Service.Id == 0)
                {
                    Session.Instance.Context.Remove(Service);
                }*/
            }
            /*try
            {
                Session.Instance.Context.SaveChanges();
                MessageBox.Show("Данные сохранены.");
                NavigationService.GoBack();
            }
            catch
            {
                MessageBox.Show("При сохранении данных возникла ошибка!");
                if (Service.Id == 0)
                {
                    Session.Instance.Context.Remove(Service);
                }
            }*/
        }

        private void updateImage(object sender, RoutedEventArgs e)
        {
            images();
        }

        private void images()
        {
            var dialog = new OpenFileDialog
            {
                Filter = "Png Images|*.png"
            };
            var result = dialog.ShowDialog();
            if (result != true)
            {
                return;
            }
            string newFilename = Guid.NewGuid().ToString().Replace("-", "") + ".png";
            string pathToCopy = $"Assets/Images/Services/{newFilename}";
            try
            {
                File.Copy(dialog.FileName, pathToCopy);
                Service.MainImagePath = newFilename;
            }
            catch
            {
                MessageBox.Show("Ошибка при копировании файла!");
            }
        }
        private void addServicePhoto(object sender, RoutedEventArgs e)
        {
            images();
        }

        private void deletedop(object sender, RoutedEventArgs e)
        {
            Service.MainImagePath = "";
        }
    }
}
