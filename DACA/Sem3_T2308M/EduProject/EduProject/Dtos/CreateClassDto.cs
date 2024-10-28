using System.ComponentModel.DataAnnotations;

namespace EduProject.Dtos
{
    public class CreateClassDto
    {
        [MaxLength(100)]
        [Display(Name = "Class name")]
        public string ClassName { get; set; }
        [Display(Name = "Room name")]
        public string RoomName { get; set; }
    }
}
