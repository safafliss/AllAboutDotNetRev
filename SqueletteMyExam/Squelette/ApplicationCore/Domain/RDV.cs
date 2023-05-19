using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class RDV
    {
        public bool Confirmation { get; set; }
        public DateTime DateRDV { get; set; }
        public virtual Client Client { get; set; }
        public virtual Prestation Prestation { get; set; }
        public int ClientFk { get; set; }
        public int PrestationFk { get; set; }
    }
}
