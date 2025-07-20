
using System.ComponentModel.DataAnnotations;

namespace PharmacySystem.Models
{
    public class Medicine
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Details { get; set; }

        [Range(0.1, 10000)]
        public decimal Price { get; set; }
    }
}
