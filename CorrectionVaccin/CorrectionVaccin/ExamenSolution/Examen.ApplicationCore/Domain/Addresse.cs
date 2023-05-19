using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen.ApplicationCore.Domain
{
    [Owned]
    public class Addresse
    {
        public int Rue { get; set; }
        public string Ville { get; set; }
        public int CodePostal { get; set; }
    }
}
