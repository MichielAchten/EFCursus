using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstCursus
{
    [ComplexType]
    public class Adres
    {
        [Column("Straat")]
        public string Straat { get; set; }
        [Column("HuisNr")]
        public string HuisNr { get; set; }
        [Column("Postcode")]
        public string Postcode { get; set; }
        [Column("Gemeente")]
        public string Gemeente { get; set; }
    }
}
