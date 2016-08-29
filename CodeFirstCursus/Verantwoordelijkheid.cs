using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstCursus
{
    [Table("Verantwoordelijkheden")]
    public class Verantwoordelijkheid
    {
        public int VerantwoordelijkheidId { get; set; }
        public string Naam { get; set; }
        public virtual ICollection<Instructeur> Instructeurs { get; set; }
    }
}
