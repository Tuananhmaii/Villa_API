using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.DTO
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public String Details { get; set; }
        public double Rate { get; set; }
        [Required]
        public int Sqft { get; set; }
        public int Occupancy { get; set; }
        public String ImageUrl { get; set; }
        public String Amenity { get; set; }
    }
}
