using EFMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFMVC.Controllers
{
    public class SubjectController : Controller
    {

        MVCContextcs db;

        public SubjectController(MVCContextcs _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            IEnumerable<Subject> subjects = db.Subjects.Select(s => s).ToList();
            return View(subjects);
        }
    }
}
