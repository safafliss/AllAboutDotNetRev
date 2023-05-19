using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceKafala : Service<Kafala>, IServiceKafala
    {
        public ServiceKafala(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public IList<Beneficiary> GetListBeneInstant()
        {
            return GetMany(k=> k.EndDate> DateTime.Now).Select(k=>k.Beneficiary).ToList();
        }
        public int totaldon(DateTime db, DateTime df)
        {
            return GetMany(k=> k.StartDate == db && k.EndDate == df).SelectMany(k=>k.Donator.Donations.Select(d=>d.Amount)).Sum();
        }

        //public int totaldon(DateTime db, DateTime df)
        //{
        //    int sum = 0;

        //    var ff = GetMany(cl => cl.startdate == db && cl.enddate == df);
        //    foreach (var item in ff)
        //    {
        //        foreach (Donation dd in item.Donator.Donations)
        //        {
        //            sum += dd.amount;
        //        }
        //    }
        //    return sum;
        //}

       
    }
}
