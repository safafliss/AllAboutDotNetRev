using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IServicePretLivre:IService<PretLivre>
    {
        public IList<Livre> LivresEntreDeuxDates(DateTime? startDate, DateTime? endDate);
        public IList<Categorie> GetCategories(Statut statut);
    }
}
