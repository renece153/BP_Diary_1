using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BP_Diary_1.Models
{
    [Keyless]
    public class bp_diary
    {

        public int bp_diary_id { get; set; }
        

        public DateTime date_record { get; set; }

        [Required(ErrorMessage = "Systolic Value Required")]
        public int systolic { get; set; }

        [Required(ErrorMessage = "Diastolic Value Required")]
        public int diastolic { get; set; }
    }
}
