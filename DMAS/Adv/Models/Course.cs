using System;
using System.ComponentModel.DataAnnotations;

namespace Adv.Models;

public class Course
{
     [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
}
