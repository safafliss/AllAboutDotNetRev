using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
   
{
    public enum TypeChambre { Simple, Double }
    public class Chambre
    {
        //[ForeignKey("Clinique")]
        public int CliniqueFK { get; set; }
        [Key]
        public int NumeroChambre { get; set; }
        public float Prix { get; set; }
        public TypeChambre TypeChambre { get; set; }
        [ForeignKey("CliniqueFK")]
        public virtual Clinique Clinique { get; set; } //propriété de navigation
        public virtual ICollection<Admission> Admissions { get; set; }
    }
}
