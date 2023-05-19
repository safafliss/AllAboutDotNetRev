using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IServiceVaccin:IService<Vaccin>
    {
        public string CheckVaccin(Vaccin vaccin);
    }
}
