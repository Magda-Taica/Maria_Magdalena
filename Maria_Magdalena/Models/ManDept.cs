using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maria_Magdalena.Models
{
    public class ManDept
    {
        public int ManDeptID { get; set; }
        public int AngajatID { get; set; }
        public int ManagerID { get; set; }
        public Manager Manager { get; set; }
        public int DepartamentID { get; set; }
        public Departament Departament { get; set; }
    }
}
