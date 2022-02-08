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
    public class IndexModel : PageModel
    {
        private readonly Maria_Magdalena.Models.Maria_MagdalenaContext _context;

        public IndexModel(Maria_Magdalena.Models.Maria_MagdalenaContext context)
        {
            _context = context;
        }

        public IList<Manager> Manager { get;set; }

        public async Task OnGetAsync()
        {
            Manager = await _context.Manager.ToListAsync();
        }
    }
}
