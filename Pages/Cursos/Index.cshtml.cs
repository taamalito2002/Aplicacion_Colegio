using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using POWApp.Data;
using POWApp.Models;

namespace POWApp.Pages.Cursos
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Curso> Curso { get; set; }

        public async Task OnGetAsync()
        {
            Curso = await _context.Curso.ToListAsync();
        }
    }
}
