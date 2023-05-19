using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class RendezVous
    {
        public string CodeInfirmiere { get; set; }
        public DateTime DateVaccination { get; set; }
        public int NbrDoses { get; set; }
        public virtual Citoyen Citoyen { get; set; }
        public virtual Vaccin Vaccin { get; set; }
        public int VaccinId { get; set; }
        public int CitoyenId { get; set; }
    }
}
