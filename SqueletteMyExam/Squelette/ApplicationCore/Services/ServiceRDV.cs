using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceRDV : Service<RDV>, IServiceRDV
    {
        public ServiceRDV(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public IGrouping<DateTime, IEnumerable<RDV>> GetRDVConfirme(Client client)
        {
            return (IGrouping<DateTime, IEnumerable<RDV>>)GetMany(r => r.ClientFk == client.Id && r.Confirmation == true).GroupBy(r => r.DateRDV);
        }
    }
}
