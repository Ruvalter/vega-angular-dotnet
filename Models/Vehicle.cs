using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace vega.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        public int ModelId { get; set; }

        public Model Model { get; set;}

        public bool IsRegistred { get; set; }

        [Required]
        [StringLength(255)]
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }

        public DateTime LastUpdate { get; set; }

        public ICollection<VehicleFeature> Features { get; set; }

        public Vehicle()
        {
            Features = new Collection<VehicleFeature>();
        }
    }
}