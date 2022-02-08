using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Maria_Magdalena.Models
{
    public class Angajat
    {
        public int ID { get; set; }

        [Display(Name = "Nume Prenume")]
        [Required(ErrorMessage = "Va rog sa completati campul."), MinLength(5, ErrorMessage = "Necesar minim 5 caractere."), MaxLength(30, ErrorMessage = "Admis maxim 30 de caractere.")]

        public string numeangajat { get; set; }


        [Display(Name = "Denumire Post")]
        [Required(ErrorMessage = "Va rog sa completati campul."), MinLength(2, ErrorMessage = "Necesar minim 2 caractere."), MaxLength(30, ErrorMessage = "Admis maxim 30 de caractere.")]
        public string post { get; set; }

        [Display(Name = "Manager")]
        [Required(ErrorMessage = "Va rog sa completati campul.")]
        public int ManagerID { get; set; }
        public Manager Manager { get; set; }

        [Display(Name = "Departament")]
        [Required(ErrorMessage = "Va rog sa completati campul.")]
        public int DepartamentID { get; set; }
        public Departament Departament { get; set; }
    }
}
