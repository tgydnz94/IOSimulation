using Microsoft.AspNetCore.Http;
using Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Course : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }

        //navigation property
        public List<Instructor> Instructors { get; set; }
        public List<Category> Categories { get; set; }

        // fotoğraf eklemek için kullanacağız.
        public string Image {  get; set; }

        [NotMapped]
        public IFormFile ImagePath { get; set; }
    }
}
