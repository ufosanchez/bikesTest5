using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bikesTest5.Models
{
    public class Bike
    {
        [Key]
        public int BikeId { get; set; }
        public string BikeName { get; set; }
        public string BikeFrame { get; set; }
        public string Color { get; set;}
        public int Weight { get; set; }
        public DateTime BikeYear { get; set;}
        public string BikeSize { get; set;}

        public decimal YourDecimalProperty { get; set; }
    }
}