using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstOefening
{
    public class Context : DbContext
    {
        public DbSet<Artikel> Artikels { get; set; }
        public DbSet<Leverancier> Leveranciers { get; set; }
        public DbSet<Artikelgroep> Artikelgroepen { get; set; }
        //public DbSet<FoodArtikel> FoodArtikels { get; set; }
        //public DbSet<NonFoodArtikel> NonFoodArtikels { get; set; }

    }
}
