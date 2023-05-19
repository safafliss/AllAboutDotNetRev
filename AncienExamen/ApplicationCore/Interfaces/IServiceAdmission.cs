using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IServiceAdmission: IService<Admission>
    {
        public IEnumerable<string> GetPatientNames(Chambre chambre, DateTime Debut);
        public float GetRecette(Clinique clinique, int annee);
    }
}
