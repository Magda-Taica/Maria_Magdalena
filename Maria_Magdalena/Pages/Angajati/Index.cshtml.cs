﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Maria_Magdalena.Models;

namespace Maria_Magdalena.Pages.Angajati
{
    public class IndexModel : PageModel
    {
        private readonly Maria_Magdalena.Models.Maria_MagdalenaContext _context;

        public IndexModel(Maria_Magdalena.Models.Maria_MagdalenaContext context)
        {
            _context = context;
        }

        public IList<Angajat> Angajat { get;set; }

        public async Task OnGetAsync()
        {
            Angajat = await _context.Angajat
                .Include(a => a.Departament)
                .Include(a => a.Manager).ToListAsync();
        }
    }
}
