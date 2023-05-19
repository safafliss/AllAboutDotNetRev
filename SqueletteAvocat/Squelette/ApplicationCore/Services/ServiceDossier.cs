using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceDossier : Service<Dossier>, IServiceDossier
    {
        public ServiceDossier(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IList<Client> GetListClients(Avocat avocat)
        {
            return GetMany(d=> d.Avocat == avocat && d.DateDepot.AddDays(10) <= DateTime.Now).Select(d=> d.Client).ToList();
        }
        //public IList<Client> GetClients(Avocat avocat)
        //{
        //    return GetMany(d => d.AvocatFK == avocat.AvocatId)
        //        .Where(d => DateTime.Now.Subtract(d.DateDepot).TotalDays < 10)
        //        .Select(d => d.Client).ToList();
        //}

        public int GetNbBySpecialite(Dossier dossier)
        {
            return GetAll().ToList().Where(d => d.Avocat.SpecialiteFk == dossier.Avocat.SpecialiteFk).Count();
        }
        public void Update(Dossier dossier)
        {
            var nbDossier = GetMany(d => d.AvocatFk == dossier.AvocatFk
            && d.Clos == true
            && d.ClientFk == dossier.ClientFk).Count();
            if (nbDossier > 3)
            {
                dossier.Frais -= dossier.Frais * 0.3;
            }
        }
    }
}
