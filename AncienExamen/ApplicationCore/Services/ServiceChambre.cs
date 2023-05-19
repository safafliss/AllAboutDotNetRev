using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceChambre : Service<Chambre>, IServiceChambre
    {
        public ServiceChambre(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public float GetPercentage(Clinique clinique)
        {
            return (float)GetMany(ch=> ch.CliniqueFK == clinique.CliniqueId && ch.TypeChambre == TypeChambre.Simple).Count()/
                GetMany(ch => ch.CliniqueFK == clinique.CliniqueId).Count() *100;
        }
    }
}
