using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Maria_Magdalena.Models;

namespace Maria_Magdalena.Pages.Manageri
{
    public class DeleteModel : PageModel
    {
        private readonly Maria_Magdalena.Models.Maria_MagdalenaContext _context;

        public DeleteModel(Maria_Magdalena.Models.Maria_MagdalenaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Manager Manager { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Manager = await _context.Manager.FirstOrDefaultAsync(m => m.ID == id);

            if (Manager == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Manager = await _context.Manager.FindAsync(id);

            if (Manager != null)
            {
                _context.Manager.Remove(Manager);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
