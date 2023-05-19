using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Beneficiary
    {
        [Key]
        [RegularExpression(@"^[0-9]{8}$")]
        public string CIN { get; set; }
        public string Name { get; set; }
        public Contact Contact { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Kafala> Kafalas { get; set; }
    }
}
