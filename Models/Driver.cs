using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Taxi_01.Models
{
    public class Driver : Person
    {
        public virtual ICollection<Ride> Rides { get; set; }

        public ICollection<Vehicle> OwnedVehicles { get; set; }
    }
}