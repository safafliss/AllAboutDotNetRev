using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IServiceKafala:IService<Kafala>
    {
        public IList<Beneficiary> GetListBeneInstant();
        public int totaldon(DateTime db, DateTime df);

    }
}
