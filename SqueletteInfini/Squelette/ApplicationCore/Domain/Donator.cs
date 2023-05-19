using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Donator
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public Contact Contact { get; set; }
        public virtual ICollection<Donation> Donations { get; set; }
        public virtual ICollection<Kafala> Kafalas { get; set; }
    }
}
