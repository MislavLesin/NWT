using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Taxi_01.Models
{
    public class Passenger : Person
    {
        public ICollection<Ride> Rides { get; set; }
    }
}