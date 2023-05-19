using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Examen.ApplicationCore.Domain
{
    public enum TypeVaccin
    {
        PFizer,
        Moderna,
        Jhonson
    }
    public class Vaccin
    {
      
        public int VaccinId { get; set; }
        public int Quantite { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateValidite { get; set; }
        public string Fournisseur { get; set; }
        public TypeVaccin TypeVaccin { get; set; }
        //[Display(Name = "CentreVaccination")]
        public int? CentreVaccinationId { get; set; }

        public string Validité { get; set; }
        public virtual ICollection<RendezVous> rendezVous { get; set; }
        [ForeignKey("CentreVaccinationId")]
        public virtual CentreVaccination centrevaccination { get; set; }
    }
   
}
