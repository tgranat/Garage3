﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Garage3.Models.ViewModels
{
    public class ParkedVehicleReceiptViewModel
    {
        public int ID { get; set; }
        [Display(Name = "Registration number")]
        public string RegNum { get; set; }
        [Display(Name = "Member")]
        public string MemberName { get; set; }
        [Display(Name = "Time of Arrival")]
        public DateTime ArrivalTime { get; set; }
        [Display(Name = "Time of Checkout")]
        public DateTime CheckOutTime { get; set; }

        // https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayformatattribute.dataformatstring?view=netcore-3.1

        [Display(Name = "Parking Time")]
        [DisplayFormat(DataFormatString = "{0:%d}d {0:%h}h {0:%m}m")]
        public TimeSpan Period { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Cost { get; set; }
        [Display(Name = "Parking Space(s)")]
        public ICollection<int> ParkingSpaces { get; set; }
    }
}
