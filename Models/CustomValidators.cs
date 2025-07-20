using System.ComponentModel.DataAnnotations;

namespace PharmacySystem.Models
{
    // Just for demonstration
    public class MustContainWordAttribute : ValidationAttribute
    {
        private readonly string _word;
        public MustContainWordAttribute(string word)
        {
            _word = word;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string str && str.Contains(_word))
                return ValidationResult.Success;

            return new ValidationResult($"Field must contain '{_word}'.");
        }
    }
}
