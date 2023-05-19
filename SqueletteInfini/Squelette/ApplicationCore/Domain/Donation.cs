using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Donation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [DataType(DataType.Currency)]
        public int Amount { get; set; }
        public virtual Donator Donator { get; set; }
        [ForeignKey("Donator")]
        public int? DonatorFk { get; set; }
    }
}
