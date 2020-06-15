using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoogleMaps.Models
{
    public class ParkingModel
    {
        private int Id { get; set; }
        private string City { get; set; }
        private string Code { get; set; }
        private string Country { get; set; }
        private string Email { get; set; }
        private long Lat { get; set; }
        private long Lot { get; set; }
        private string Name { get; set; }
        private string Phone { get; set; }
        private string State { get; set; }
        private string Type { get; set; }
        private string Capacity { get; set; }
        private string Busy { get; set; }

    }
}