using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Maria_Magdalena.Models
{
    public class Manager
    {
        public int ID { get; set; }

        [Display(Name = "Nume Prenume")]
        [Required(ErrorMessage = "Va rog sa completati campul.."), MinLength(3, ErrorMessage = "Necesar minim trei caractere."), MaxLength(30, ErrorMessage = "Admis maxim 30 de caractere.")]
        public string numemanager { get; set; }
        public ICollection<ManDept> ManDept { get; set; }
    }
}
