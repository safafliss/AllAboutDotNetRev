using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen.ApplicationCore.Domain
{
    public class CentreVaccination
    {
        public int CentreVaccinationId { get; set; }
        
        public int Capacite { get; set; }
        public int NbChaises { get; set; }
        public int NumTelephone { get; set; }
        public string ResponsableCentre { get; set; }

        public virtual ICollection<Vaccin> vaccins { get; set; }
    }
}
