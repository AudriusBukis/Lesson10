using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTen.Models
{
    public class Books : Publications
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Books(string type, string genre, string author, string description, string title, string publishingOffice ) : base(type, genre, description, publishingOffice)
        {
            Title = title;
            Author = author; 
        }
        public Books(string type, string genre, string author, string description, string title) : base(type, genre, description)
        {
            Title = title;
            Author = author;
        }

        public Books(string type, string genre, string author, string title) : base(type, genre)
        {
            Title = title;
            Author = author;
        }


    }
}
