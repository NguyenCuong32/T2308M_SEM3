﻿using System.ComponentModel.DataAnnotations;

namespace EduProjectDemo.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string ClassName { get; set; }
        public string RoomName { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}
