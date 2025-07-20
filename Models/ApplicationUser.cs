using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PharmacySystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
