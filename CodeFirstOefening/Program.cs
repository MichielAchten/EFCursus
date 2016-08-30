using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstOefening
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
            
            using(var context = new Context())
            {
                var artikelgroep1 = new Artikelgroep { Naam = "Artikelgroep1" };

                var artikel1 = new NonFoodArtikel { Naam = "Artikel1", Garantie = 10 };
                var artikel2 = new NonFoodArtikel { Naam = "Artikel2", Garantie = 20 };
                var artikel3 = new FoodArtikel { Naam = "Artikel3", Houdbaarheid = 30 };

                var leverancier1 = new Leverancier { Naam = "Leverancier1", Artikels = new List<Artikel> { artikel1, artikel2 } };
                var leverancier2 = new Leverancier { Naam = "Leverancier2", Artikels = new List<Artikel> { artikel3 } };

                //artikel1.Leveranciers = new List<Leverancier> { leverancier1 };
                //artikel2.Leveranciers = new List<Leverancier> { leverancier1 };
                //artikel3.Leveranciers = new List<Leverancier> { leverancier2 };

                artikelgroep1.Artikels = new List<Artikel> { artikel1, artikel2, artikel3 };

                context.Artikelgroepen.Add(artikelgroep1);
                context.Artikels.Add(artikel1);
                context.Artikels.Add(artikel2);
                context.Artikels.Add(artikel3);
                context.Leveranciers.Add(leverancier1);
                context.Leveranciers.Add(leverancier2);

                context.SaveChanges();
            }
        }
    }
}
