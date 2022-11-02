using MagicVilla_VillaAPI.Models.DTO;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
           new VillaDTO{Id = 1, Name="Muong Thanh", Sqrt = 20, Occupancy = 10},
           new VillaDTO{Id = 2, Name="Continental",Sqrt = 40, Occupancy = 30},
        };
    }
}
