using DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;
using Models.Concrete;

namespace IOApp.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseDal _courseDal;
        public CourseController(ICourseDal courseDal)
        {
                _courseDal = courseDal;
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Course course)
        {
            course.Title = "Kurs Başlığı";
            course.Description = "Kurs açıklaması";
            course.Image = "~/wwwroot/images/default.png";
            _courseDal.Add(course);
            return RedirectToAction("Add");
        }
    }
}
