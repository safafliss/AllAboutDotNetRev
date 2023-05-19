using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IServiceDossier:IService<Dossier>
    {
        public IList<Client> GetListClients(Avocat avocat);
        public int GetNbBySpecialite(Dossier dossier);
        public void Update(Dossier dossier);
    }
}
