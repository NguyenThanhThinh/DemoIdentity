using System;

namespace DemoIdentity.Domain.Entities
{
    using System.ComponentModel.DataAnnotations;
    using static DomainConstants;
    public class Article : BaseDomain
    {
        [Required]
        [MinLength(ArticleTitleMinLength)]
        [MaxLength(ArticleTitleMaxLength)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        public string AuthorId { get; set; }

        public User Author { get; set; }
    }
}
