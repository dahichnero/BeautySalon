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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public Service Service { get; set; }

        public List<Service> Services { get; set; }

        public Client Client { get; set; }

        public List<Client> Clients { get; set; }

        public RegistrationPage( Service service)
        {
            Service = service;
            Services = Session.Instance.Context.Services.OrderBy(s => s.Title).ToList();
            Clients = Session.Instance.Context.Clients.ToList();
            InitializeComponent();
            DataContext = this;
            serviceDatePicker.DisplayDateStart = DateTime.Today;
            serviceDatePicker.SelectedDate = DateTime.Today;
            serviceTimePicker.SelectedTime = new DateTime().AddHours(12);
        }

        /*private void serviceTimePicker_SelectedTimeChanged(object sender, RoutedPropertyChangedEventArgs<DateTime?> e)
        {
            DateTime date = serviceTimePicker.SelectedTime.Value;
            if (date.Minute > 0)
            {
                
                date = date.AddHours(1);
                date = date.AddMinutes(60 - date.Minute);
            }
            serviceTimePicker.SelectedTime = date;
        }*/

        private void registration(object sender, RoutedEventArgs e)
        {
            var time = serviceTimePicker.SelectedTime.Value;
            if (time.Minute > 0)
            {
                time = time.AddMinutes(60 - time.Minute);
            }
            var date = serviceDatePicker.SelectedDate.Value;
            var startTime = date.AddTicks(time.Ticks);
            var clientService = new ClientService
            {
                Client = this.Client,
                Service = this.Service,
                StartTime = startTime,
                Comment=com.Text
            };
            Session.Instance.Context.ClientServices.Add(clientService);
            try
            {
                Session.Instance.Context.SaveChanges();
                MessageBox.Show("Клиент записан!");
                NavigationService.GoBack();
            }
            catch
            {
                MessageBox.Show("Ошибки при записи клиента!");
                Session.Instance.Context.ClientServices.Remove(clientService);
            }

        }

        private void backto(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
