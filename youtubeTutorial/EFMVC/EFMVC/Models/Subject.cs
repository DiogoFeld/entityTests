namespace EFMVC.Models
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public string SubjectTerm { get; set; }
        public int SubjectCredets { get; set; }
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();

    }
}
