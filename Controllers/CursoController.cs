using Microsoft.AspNetCore.Mvc;
using POWApp.Data; 
using POWApp.Models; 
using System.Linq;

namespace POWApp.Controllers
{
    public class CursoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CursoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var cursos = _context.Curso.ToList(); // Trae los cursos
            return View(cursos); // Envía la lista a la vista
        }
    }
}
