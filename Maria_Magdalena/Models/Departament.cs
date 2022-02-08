using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Maria_Magdalena.Models
{
    public class Departament
    {
        public int ID { get; set; }

        [Display(Name = "Departament")]
        [Required(ErrorMessage = "Va rog sa completati campul.."), MinLength(3, ErrorMessage = "Necesar minim trei caractere."), MaxLength(30, ErrorMessage = "Admis maxim 30 de caractere.")]
        public string dept { get; set; }

        public ICollection<Angajat> Angajat { get; set; }
    }
}
