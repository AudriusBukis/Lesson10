using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTen.Models
{
    public abstract class Publications
    {
        public Guid Id { get; private set; }
        public string Type { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string PublishingOffice { get; set; }

        protected Publications(string type, string genre, string description, string publishingOffice)
        {
            Id = Guid.NewGuid();
            Type = type;
            Genre = genre;
            Description = description;
            PublishingOffice = publishingOffice;
        }

        protected Publications(string type, string genre, string description)
        {
            Id = Guid.NewGuid();
            Type = type;
            Genre = genre;
            Description = description;
        }

        protected Publications(string type, string genre)
        {
            Id = Guid.NewGuid();
            Type = type;
            Genre = genre;
        }
    }
}
