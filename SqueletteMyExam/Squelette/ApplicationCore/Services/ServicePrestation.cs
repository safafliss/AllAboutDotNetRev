using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServicePrestation : Service<Prestation>, IServicePrestation
    {
        public ServicePrestation(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public double GetPrixMoy()
        {
            return GetMany(p => p.PrestationType == Domain.Type.Coiffure).Select(p=> p.Prix).Average();
        }
    }
}
