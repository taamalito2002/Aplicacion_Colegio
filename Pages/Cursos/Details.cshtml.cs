using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using POWApp.Data;
using POWApp.Models;

namespace POWApp.Pages.Cursos
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Curso Curso { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

#pragma warning disable CS8601 // Posible asignación de referencia nula
            Curso = await _context.Curso
                .FirstOrDefaultAsync(m => m.Id == id);
#pragma warning restore CS8601 // Posible asignación de referencia nula

            if (Curso == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
