namespace Entities
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int? Credits { get; set; }
        public int? TeacherID { get; set; }

        public Teacher? Teacher { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set;}
    }
}
