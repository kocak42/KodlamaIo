
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Course:IEntity
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Goals { get; set; }

        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
    }
}
