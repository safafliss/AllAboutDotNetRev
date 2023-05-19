using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Livre
    {
        [Required]
        public string Isbn { get; set; }
        public string Titre { get; set; }
        public int LivreId { get; set; }
        public int NbreExemplaires { get; set; }
        public string Auteur { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateCreation { get; set; }
        public virtual ICollection<PretLivre> PretLivres { get; set; }
        public virtual Categorie Categorie { get; set; }
        public int CategorieId { get; set; }
    }
}
