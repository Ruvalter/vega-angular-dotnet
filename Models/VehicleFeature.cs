
//That class is necessary to handle many-to-many type of relationship

using System.ComponentModel.DataAnnotations.Schema;

namespace vega.Models
{
    [Table("VehicleFeatures")]
    public class VehicleFeature
    {
        //foreign keys
        public int VehicleId { get; set; }
    
        public int FeatureId { get; set; }

        //Navigation properties
        public Vehicle Vehicle { get; set; }
        public Feature Feature { get; set; }
    }
}