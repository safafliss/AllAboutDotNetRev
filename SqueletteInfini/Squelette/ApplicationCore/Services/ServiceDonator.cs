using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceDonator : Service<Donator>, IServiceDonator
    {
        public ServiceDonator(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public IList<Donator> GetDonatorsNoKafala()
        {
            return GetMany(d=> d.Kafalas.Count() == 0 && d.Donations.Count() !=0 ).ToList();
        }
    }
}
