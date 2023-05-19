using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceLivre : Service<Livre>, IServiceLivre
    {
        public ServiceLivre(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public Livre GetMaxEmprunt()
        {
            Livre livrePlus = new Livre();    
            var Livres = GetAll();
            int nbr = 0;
            foreach(var item in Livres)
            {
                if (item.PretLivres.Count() > nbr)
                {
                    nbr= item.PretLivres.Count();
                    livrePlus = item;
                }
            }
            return livrePlus;
            //or
            //return GetAll().OrderByDescending(e => e.PretLivres.Count).FirstOrDefault();
        }
    }
}
