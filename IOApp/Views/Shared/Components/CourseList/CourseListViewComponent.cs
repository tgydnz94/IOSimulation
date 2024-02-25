using DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;
using Models.Concrete;

namespace IOApp.Views.Shared.Components.CourseList
{
    public class CourseListViewComponent : ViewComponent
    {
        private readonly ICourseDal _courseDal;

        public CourseListViewComponent(ICourseDal courseDal)
        {
            _courseDal=courseDal;
        }
        public IViewComponentResult Invoke()
        {
            var result = _courseDal.GetAll();
            return View(result);
        }
    }
}
