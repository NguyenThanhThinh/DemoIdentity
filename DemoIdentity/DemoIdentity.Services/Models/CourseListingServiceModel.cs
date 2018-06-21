using System;
namespace DemoIdentity.Services.Models
{
    using DemoIdentity.Utilities.Mapping;
    using DemoIdentity.Domain.Entities;
    using AutoMapper;

    public class CourseListingServiceModel : IMapFrom<Course>, IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Trainer { get; set; }

        public void ConfigureMapping(Profile profile)
        {
            profile.CreateMap<Course, CourseListingServiceModel>()
                .ForMember(c => c.Trainer,
                cfg => cfg.MapFrom(c => $"{c.Trainer.Name} ({c.Trainer.UserName})"));
        }
    }
}
