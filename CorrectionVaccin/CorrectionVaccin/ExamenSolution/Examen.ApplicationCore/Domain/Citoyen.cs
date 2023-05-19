using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen.ApplicationCore.Domain
{
    public class Citoyen
    {
     [Key]
        public string CIN { get; set; }

        [Required(ErrorMessage = "champs obligatoire")]
        public int NumeroEvax { get; set; }
        public int CitoyenId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public int Telephone { get; set; }

        public Addresse Addresse { get; set; }

        public virtual ICollection<RendezVous> rendezVous { get; set; }

    }


}
