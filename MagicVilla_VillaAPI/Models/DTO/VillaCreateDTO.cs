using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.DTO
{
    public class VillaCreateDTO
    {
        [Required]
        public String Name { get; set; }
        public String Details { get; set; }
        [Required]
        public double Rate { get; set; }
        public int Sqft { get; set; }
        public int Occupancy { get; set; }
        public String ImageUrl { get; set; }
        public String Amenity { get; set; }
    }
}
