using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using PharmacySystem.Models;

namespace PharmacySystem.ViewModels
{
    // Demonstration ViewModel with all types of validation
    public class FakeValidationViewModel
    {
        [Required]
        [StringLength(50)]
        public string Field { get; set; }

        [MustContainWord("med")]
        public string CustomField { get; set; }

        [Remote(action: "CheckFake", controller: "Fake")]
        public string RemoteField { get; set; }
    }
}
