using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace BeautySalon.Models;

public partial class ClientService
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public int ServiceId { get; set; }

    public DateTime StartTime { get; set; }

    public string? Comment { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual ICollection<DocumentByService> DocumentByServices { get; } = new List<DocumentByService>();

    public virtual ICollection<ProductSale> ProductSales { get; } = new List<ProductSale>();

    public virtual Service Service { get; set; } = null!;

    public double OstTime
    {
        get
        {
            DateTime now=DateTime.Now;
            double ost = (StartTime - now).Hours;
            return ost;
        }
    }

    public double OstTimeMin
    {
        get
        {
            DateTime now = DateTime.Now;
            double ost = (StartTime - now).Minutes;
            return ost;
        }
    }

    public bool OstTimeDay
    {
        get
        {
            DateTime now = DateTime.Now;
            double day = (StartTime - now).Days;
            double ost = (StartTime - now).Hours;
            if (day<=0 && ost <= 0)
            {
                return false;
            }
            else if (day>0 && ost > 0)
            {
                return true;
            }
            else if (day>0 && ost <= 0)
            {
                return true;
            }
            else if (day<=0 && ost > 0)
            {
                return true;
            }
            return false;
        }
    }
}
