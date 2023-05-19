using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IServiceRendezVous:IService<RendezVous>
    {
        public bool Check(DateTime DateVacc, CentreVaccination centre);
    }
}
