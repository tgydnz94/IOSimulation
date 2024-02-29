using AutoMapper;
using DataAccess.Abstract;
using IOApp.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Models.Concrete;

namespace IOApp.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseDal _courseDal;
        private readonly IMapper _mapper;

        public CourseController(ICourseDal courseDal, IMapper mapper)
        {
                _courseDal = courseDal;
            _mapper=mapper;
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddCourseDto dto)
        {
            var course = _mapper.Map<Course>(dto);
            using var image = Image.Load(dto.ImagePath.OpenReadStream());  // fotoğrafı yükleyip okuduk
            image.Mutate(a => a.Resize(80, 80));

            Guid guid = Guid.NewGuid();
            image.Save($"wwwroot/images/{guid}.jpeg");

            course.Image = $"/images/{guid}.jpeg";

            _courseDal.Add(course);
            return RedirectToAction("Index", "Main");
        }
    }
}
