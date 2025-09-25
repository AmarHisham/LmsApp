using System.ComponentModel.DataAnnotations;

namespace LmsApp.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
