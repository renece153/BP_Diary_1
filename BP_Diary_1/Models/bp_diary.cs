using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BP_Diary_1.Models
{
    public class bp_diary_records
    {
        [Key] // Specifies that Id is the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-increment
        public int bp_diary_id { get; set; }

        [Required]
        public DateTime date_record { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Systolic Value Required")]
        public int systolic { get; set; }

        [Required(ErrorMessage = "Diastolic Value Required")]
        public int diastolic { get; set; }
    }
}
