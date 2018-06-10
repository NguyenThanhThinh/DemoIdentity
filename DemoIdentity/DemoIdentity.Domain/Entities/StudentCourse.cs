namespace DemoIdentity.Domain.Entities
{
    using DemoIdentity.Domain.Enums;
    public class StudentCourse
    {
        public string StudentId { get; set; }

        public User Student { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }

        public Grade? Grade { get; set; }
    }
}
