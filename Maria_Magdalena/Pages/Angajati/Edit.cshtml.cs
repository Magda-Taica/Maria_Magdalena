using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Maria_Magdalena.Models;

namespace Maria_Magdalena.Pages.Angajati
{
    public class EditModel : PageModel
    {
        private readonly Maria_Magdalena.Models.Maria_MagdalenaContext _context;

        public EditModel(Maria_Magdalena.Models.Maria_MagdalenaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Angajat Angajat { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Angajat = await _context.Angajat
                .Include(a => a.Departament)
                .Include(a => a.Manager).FirstOrDefaultAsync(m => m.ID == id);

            if (Angajat == null)
            {
                return NotFound();
            }
           ViewData["DepartamentID"] = new SelectList(_context.Set<Departament>(), "ID", "dept");
           ViewData["ManagerID"] = new SelectList(_context.Set<Manager>(), "ID", "numemanager");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Angajat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AngajatExists(Angajat.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AngajatExists(int id)
        {
            return _context.Angajat.Any(e => e.ID == id);
        }
    }
}
