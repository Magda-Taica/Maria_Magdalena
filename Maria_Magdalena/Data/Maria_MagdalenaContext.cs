using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Maria_Magdalena.Models;

namespace Maria_Magdalena.Models
{
    public class Maria_MagdalenaContext : DbContext
    {
        public Maria_MagdalenaContext (DbContextOptions<Maria_MagdalenaContext> options)
            : base(options)
        {
        }

        public DbSet<Maria_Magdalena.Models.Angajat> Angajat { get; set; }

        public DbSet<Maria_Magdalena.Models.Departament> Departament { get; set; }

        public DbSet<Maria_Magdalena.Models.Manager> Manager { get; set; }
    }
}
