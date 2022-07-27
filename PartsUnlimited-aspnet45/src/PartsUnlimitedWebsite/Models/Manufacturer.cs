using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    public class Manufacturer
    {
        // Modificando CS denominado Manufacturer
        public int ManufacturerId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}