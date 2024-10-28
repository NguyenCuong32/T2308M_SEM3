using System.ComponentModel;

namespace EduProjectDemo.Dtos
{
    public class CreateClassDto
    {
        [DisplayName("Class name")]
        public string ClassName { get; set; }
        [DisplayName("Class room")]
        public string RoomName { get; set; }
    }
}
