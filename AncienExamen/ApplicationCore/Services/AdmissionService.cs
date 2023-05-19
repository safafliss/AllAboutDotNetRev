using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class AdmissionService : Service<Admission>, IServiceAdmission
    {
        public AdmissionService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<string> GetPatientNames(Chambre chambre, DateTime Debut)
        {
            return GetMany(a => a.ChambreFK == chambre.NumeroChambre && DateTime.Compare(a.DateAdmission, Debut) > 0).Select(a => a.Patient.NomComplet.Nom);
        }

        public float GetRecette(Clinique clinique, int annee)
        {
            return GetMany(a => a.Chambre.CliniqueFK == clinique.CliniqueId && a.DateAdmission.Year == annee)
                .Sum(a => a.Chambre.Prix * a.NbJours);
        }
    }
}
