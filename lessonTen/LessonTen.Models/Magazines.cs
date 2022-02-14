using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTen.Models
{
    internal class Magazines : Publications
    {
        
        public Magazines(string type, string genre, string description, string publishingOffice) : base(type, genre, description, publishingOffice)
        {

        }
    }
}
