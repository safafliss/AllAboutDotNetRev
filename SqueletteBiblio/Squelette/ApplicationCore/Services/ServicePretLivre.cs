using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServicePretLivre : Service<PretLivre>, IServicePretLivre
    {
        public ServicePretLivre(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public IList<Livre> LivresEntreDeuxDates(DateTime? startDate, DateTime? endDate)
        {
            return GetMany(p=>p.DateDebut == startDate && p.DateFin == endDate).Select(p=> p.Livre).ToList();
        }
        //public IEnumerable<Livre> GetLivresPretes(DateTime debut, DateTime fin)
        //{
        //    return GetMany(e => e.DateDebut >= debut && e.DateFin <= fin).Select(e => e.Livre);
        //}
        public IList<Categorie> GetCategories(Statut statut)
        {
            return GetMany(p=>p.Abonne.Statut.Equals(statut)).Select(p=>p.Livre.Categorie).ToList();
        }
        //public IEnumerable<Categorie> GetCategoriesLivresPretes(Statut statut)
        //{
        //    return GetMany(e => e.Abonne.Statut == statut).
        //        Select(e => e.Livre.Categorie).GroupBy(e => e.Code).Select(e => e.First());
        //}
    }
}
