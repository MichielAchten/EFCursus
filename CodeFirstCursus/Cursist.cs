﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstCursus
{
    [Table("Cursisten")]
    public class Cursist
    {
        [Key]
        public int CursistId { get; set; }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public virtual ICollection<Cursist> Beschermelingen { get; set; }
        [InverseProperty("Beschermelingen")]
        public virtual Cursist Mentor { get; set; }
    }
}
