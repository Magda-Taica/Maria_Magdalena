using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Maria_Magdalena.Models;

namespace Maria_Magdalena.Pages.Departamente
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
            return Page();
        }

        [BindProperty]
        public Departament Departament { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Departament.Add(Departament);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}