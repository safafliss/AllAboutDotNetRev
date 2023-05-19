using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceSpecialite : Service<Specialite>, IServiceSpecialite
    {
        public ServiceSpecialite(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Specialite GetMax()
        {
            Specialite sp= new Specialite();
            int max = 0;
            var specialiteList = GetAll();
            foreach(Specialite specialite in specialiteList)
            {
                if (max < specialite.Avocats.Count())
                {
                    max= specialite.Avocats.Count();
                    sp= specialite;
                }
            }
            return sp;
        }
        //public Specialite GetByMaxAvocats()
        //{
        //    return GetMany().OrderByDescending(s => s.Avocats.Count()).FirstOrDefault();
        //}
    }
}
