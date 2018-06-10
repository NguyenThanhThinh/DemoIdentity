using System;
using System.Collections.Generic;

namespace DemoIdentity.Domain.Entities
{
    using System.ComponentModel.DataAnnotations;
    using static DomainConstants;
    public class Course : BaseDomain
    {
        [Required]
        [MaxLength(CourseNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(CourseDescriptionMaxLength)]
        public string Description { get; set; }

        public string TrainerId { get; set; }

        public User Trainer { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public ICollection<StudentCourse> Students { get; set; } = new List<StudentCourse>();
    }
}
