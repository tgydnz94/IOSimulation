using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Instructor: BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} + {LastName}";
        
        //navigation property
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
