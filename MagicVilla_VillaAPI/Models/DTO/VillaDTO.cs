using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.DTO
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public int Sqrt { get; set; }
        public int Occupancy { get; set; }
    }
}
