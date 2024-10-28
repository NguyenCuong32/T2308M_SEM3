using System.ComponentModel;

namespace EduProjectDemo.Dtos
{
    public class GetStudentReportDto
    {
        [DisplayName("Student name")]
        public string StudentName { get; set; }
        [DisplayName("Student Age")]
        public int Age { get; set; }
        [DisplayName("Address")]
        public string Address { get; set; }
        [DisplayName("Course name")]
        public string CourseName { get; set; }
        [DisplayName("Class name")]
        public string ClassName { get; set; }
    }
}
