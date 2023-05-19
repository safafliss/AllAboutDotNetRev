using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    internal class ServiceCitoyen : Service<Citoyen>, IServiceCitoyen
    {
        public ServiceCitoyen(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IGrouping<string, IEnumerable<Citoyen>> GetCitoyensVaccinés()
        {
            return (IGrouping<string, IEnumerable<Citoyen>>)GetMany(c => c.Rendezs.Count >= 0).GroupBy(c => c.Addresse.Ville);
        }
    }
}
