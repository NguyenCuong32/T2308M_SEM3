using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduProject.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [Range(1, 150)]
        public int Age { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        [ForeignKey("ClassId")]
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}
