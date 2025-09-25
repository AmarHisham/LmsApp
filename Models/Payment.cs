using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LmsApp.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public string SlipUrl { get; set; }
        public string Status { get; set; } = "Pending";
    }
}
