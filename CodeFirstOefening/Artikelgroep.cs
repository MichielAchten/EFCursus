using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstOefening
{
    [Table("Artikelgroepen")]
    public class Artikelgroep
    {
        public int Id { get; set; }
        public string Naam { get; set; }

        public ICollection<Artikel> Artikels { get; set; }
    }
}
