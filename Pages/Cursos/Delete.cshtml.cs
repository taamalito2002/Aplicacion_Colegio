using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using POWApp.Data;
using POWApp.Models;

namespace POWApp.Pages.Cursos
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Curso Curso { get; set; } = default!;

        // Cargar el curso que se quiere eliminar
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Curso? curso = await _context.Curso
                .FirstOrDefaultAsync(m => m.Id == id);

            if (curso == null)
            {
                return NotFound();
            }

            Curso = curso;
            return Page();
        }

        // Eliminar el curso y redirigir a la lista
        public async Task<IActionResult> OnPostAsync(int id)
        {
            var curso = await _context.Curso.FindAsync(id);

            if (curso != null)
            {
                _context.Curso.Remove(curso);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
