using Models.Concrete;
using System.ComponentModel.DataAnnotations.Schema;

namespace IOApp.Models.Dtos
{
    public class AddCourseDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }

        // fotoğraf eklemek için kullanacağız.
        public string? Image { get; set; }

        [NotMapped]
        public IFormFile? ImagePath { get; set; }
    }
}
