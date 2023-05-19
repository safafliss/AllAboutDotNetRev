using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceAbonne : Service<Abonne>, IServiceAbonne
    {
        public ServiceAbonne(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
