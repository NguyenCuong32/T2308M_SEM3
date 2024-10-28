﻿using System.ComponentModel.DataAnnotations;

namespace EduProjectDemo.Models
{
    public class StudentCourse
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }
}
