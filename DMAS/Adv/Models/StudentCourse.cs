using System;
using System.ComponentModel.DataAnnotations;

namespace Adv.Models;

public class StudentCourse
{
    [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
}
