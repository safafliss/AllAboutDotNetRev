﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Patient
    {
        [DataType(DataType.EmailAddress)]
        public string AdresseEmail { get; set; }
        [Key]
        public string CIN { get; set; }
        public NomComplet NomComplet { get; set; }

        [Range(0,9999)]
        public int NumDossier { get; set; }
        public int NumTel { get; set; }
        public virtual ICollection<Admission> Admissions { get; set; }
    }
}
