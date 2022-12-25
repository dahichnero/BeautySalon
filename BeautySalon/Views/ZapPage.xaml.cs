using BeautySalon.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace BeautySalon.Views
{
    /// <summary>
    /// Логика взаимодействия для ZapPage.xaml
    /// </summary>
    public partial class ZapPage : Page, INotifyPropertyChanged
    {
        public ObservableCollection<ClientService> ClientServices
        { 
            get { return _client; }
            private set
            {
                _client = value;



                notifyPropertyChanged("ClientServices");
            }
        }

        ObservableCollection<ClientService> _client = new ObservableCollection<ClientService>();
        public ObservableCollection<Client> Clients { get; private set; }
        public ObservableCollection<Service> Services { get; private set; }

        DispatcherTimer _refreshTimer = new DispatcherTimer();
        public bool IsAdmin { get; private set; }

        DateTime tomorrow = DateTime.Today.AddDays(1);
        public ZapPage(bool isAdmin)
        {
            IsAdmin = isAdmin;
            ClientServices = new ObservableCollection<ClientService>(Session.Instance.Context.ClientServices.OrderBy(s => s.StartTime).Where(s=>s.StartTime.Month==DateTime.Today.Month && s.StartTime.Year==DateTime.Today.Year
            && s.StartTime.Day==DateTime.Today.Day || s.StartTime.Day==tomorrow.Day && s.StartTime.Month==tomorrow.Month && s.StartTime.Year==tomorrow.Year));
            Clients = new ObservableCollection<Client>(Session.Instance.Context.Clients);
            Services = new ObservableCollection<Service>(Session.Instance.Context.Services);
            InitializeComponent();
            _refreshTimer.Interval = TimeSpan.FromSeconds(30);
            _refreshTimer.Tick += new EventHandler(_refreshTimer_Tick);
            _refreshTimer.Start();
            this.DataContext = this;
        }

        

        void _refreshTimer_Tick(object sender, EventArgs e)
        {
            ClientServices = new ObservableCollection<ClientService>(Session.Instance.Context.ClientServices.OrderBy(s => s.StartTime).Where(s => s.StartTime.Month == DateTime.Today.Month && s.StartTime.Year == DateTime.Today.Year
            && s.StartTime.Day == DateTime.Today.Day || s.StartTime.Day == tomorrow.Day && s.StartTime.Month == tomorrow.Month && s.StartTime.Year == tomorrow.Year));

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void notifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }
}
