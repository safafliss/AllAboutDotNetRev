using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceVaccin : Service<Vaccin>, IServiceVaccin
    {
        public ServiceVaccin(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public string CheckVaccin(Vaccin vaccin)
        {
            if(vaccin.DateValidite >= DateTime.Now && vaccin.Quantite > 0)
            {
                return "Valide";
            }
            return "Non Valide";
        }
    }
}
