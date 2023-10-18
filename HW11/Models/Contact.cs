using System.ComponentModel.DataAnnotations;

namespace HW11.Models
{
    public class Contact
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? PhoneNumber { get; set; }

        public string? AlternativePhoneNumber { get; set; }

        [Required]
        public string? Email { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }

    }
}
