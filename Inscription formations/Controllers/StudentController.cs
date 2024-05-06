using Inscription_formations.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inscription_formations.Controllers
{
    public class TrainingController : Controller
    {
        private readonly ETrainingDbContext context;

        public StudentController(ETrainingDbContext context)
        {
            this.context = context;
        }

        public ActionResult Index()
        {

            return View(context.Students.ToList());
        }


        public ActionResult Details(int id)
        {
            Student student = context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return View();
        }
    }
}
