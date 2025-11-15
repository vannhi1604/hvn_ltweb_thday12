using ltweb_th1.Data;
using ltweb_th1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ltweb_th1.ViewComponents
{
    public class MajorViewComponent: ViewComponent
    {
        SchoolContext db;
        List<Major> majors;

        public MajorViewComponent(SchoolContext _context)
        {
            db = _context;
            majors = db.Majors.ToList();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderMajor", majors);
        }
    }
}
