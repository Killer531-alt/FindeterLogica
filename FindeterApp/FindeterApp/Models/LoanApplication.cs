using System.ComponentModel.DataAnnotations;

namespace FindeterApp.Models
{
    public class LoanApplication
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string CompanyName { get; set; }

        // Add other properties as per your table structure
        // For brevity, they are not listed here
    }
}
