using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;

namespace BeautySalon.Models;

public partial class Service : INotifyPropertyChanged
{
    private string? mainImagePath;
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public decimal Cost { get; set; }

    public int DurationInSeconds { get; set; }

    public string? Description { get; set; }

    public double? Discount { get; set; }

    public string? MainImagePath
    { 
        get => mainImagePath;
        set
        {
            mainImagePath = value;
            notifyPropertyChanged(nameof(MainImagePath));
        }
    }

    public virtual ICollection<ClientService> ClientServices { get; } = new List<ClientService>();

    public virtual ICollection<ServicePhoto> ServicePhotos { get; }
    = new ObservableCollection<ServicePhoto>();

    public decimal CostWithDiscount
    {
        get { return Cost*(1-(decimal)Discount); }
    }
    public int DurationInMinutes 
    { 
        get { return DurationInSeconds / 60; }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void notifyPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}
