using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Category : BaseModel
    {
        public string CategoryName { get; set; }
        public int CourseId { get; set; }
    }
}
