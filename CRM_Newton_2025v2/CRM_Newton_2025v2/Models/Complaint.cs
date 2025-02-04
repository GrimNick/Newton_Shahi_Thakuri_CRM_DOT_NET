using System.ComponentModel.DataAnnotations;

namespace CRM_Newton_2025v2.Models
{
    public class Complaint
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public string Contact { get; set; }

        [Display(Name = "Complaint/Feedback")]
        public string Message { get; set; }

    }
}
