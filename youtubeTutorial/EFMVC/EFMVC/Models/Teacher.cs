using System.ComponentModel.DataAnnotations;

namespace EFMVC.Models
{
    public class Teacher
    {        
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherAdress{ get; set; }
        public int TeacherAge{ get; set; }
        public Subject Subject { get; set; } = new Subject();



    }
}
