using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasicApp.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [DisplayName("Student's Name")]
        public string Name { get; set; }

        [DisplayName("Student's Score")]
        [Range(0, 100)]
        public int Score { get; set; }
    }
}
