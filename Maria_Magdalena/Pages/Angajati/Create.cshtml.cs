using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Maria_Magdalena.Models;

namespace Maria_Magdalena.Pages.Angajati
{
    public class CreateModel : PageModel
    {
        private readonly Maria_Magdalena.Models.Maria_MagdalenaContext _context;

        public CreateModel(Maria_Magdalena.Models.Maria_MagdalenaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DepartamentID"] = new SelectList(_context.Set<Departament>(), "ID", "dept");
        ViewData["ManagerID"] = new SelectList(_context.Set<Manager>(), "ID", "numemanager");
            return Page();
        }

        [BindProperty]
        public Angajat Angajat { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Angajat.Add(Angajat);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}