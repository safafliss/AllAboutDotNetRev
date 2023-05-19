using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public enum Statut { Etudiant, Enseignant, Autre}
    public class Abonne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        [Key]
        public int Id { get; set; }
        public Statut Statut { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public DateTime DateCreation { get; set; }
        public virtual ICollection<PretLivre> PretLivres { get; set; }
    }
}
