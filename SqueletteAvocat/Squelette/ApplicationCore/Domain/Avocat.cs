using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Avocat
    {
        public int AvocatId { get; set; }
        [Required(ErrorMessage ="obli")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "obli")]
        public string Prenom { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateEmbauche { get; set; }
        public virtual Specialite Specialite { get; set; }
        public virtual ICollection<Dossier> Dossiers { get; set; }
        //[ForeignKey("Specialite")]
        public int SpecialiteFk { get; set; }
        [NotMapped]
        public string Information
        {
            get
            {
                return Prenom + " " + Nom;
            }
        }
    }
}
