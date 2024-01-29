using System.ComponentModel.DataAnnotations;

namespace Tutorial.Models.Dto
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public int Occupancy { get; set; }

        public int Sqft { get; set; }
    }
}
