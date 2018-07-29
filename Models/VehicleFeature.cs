
//That class is necessary to handle many-to-many type of relationship

namespace vega.Models
{
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