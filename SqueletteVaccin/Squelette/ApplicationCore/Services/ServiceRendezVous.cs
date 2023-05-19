using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceRendezVous : Service<RendezVous>, IServiceRendezVous
    {
        public ServiceRendezVous(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public bool Check(DateTime DateVacc, CentreVaccination centre)
        {
            if(GetMany(r=>r.DateVaccination == DateVacc && r.Vaccin.CentreVaccination == centre).Count() < centre.Capacite)
            {
                return true;
            }
            return false;
        }
    }
}
