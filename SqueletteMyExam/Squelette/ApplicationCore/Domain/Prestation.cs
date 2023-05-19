using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public enum Type { Coiffure, Maquillage, Onglerie, Soin}
    public class Prestation
    {
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string Intitule { get; set; }
        public int PrestationId { get; set; }
        public Type PrestationType { get; set; }
        [DataType(DataType.Currency)]
        public double Prix { get; set; }
        public virtual ICollection<RDV> RDVs { get; set; }
        public virtual Prestataire Prestataire { get; set; }
        [ForeignKey("Prestataire")]
        [Display(Name = "PrestataireFk")]
        public int? PrestataireFk { get; set; }
    }
}
