using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<VDABContext>());

            using (var context = new VDABContext())
            {
                Cursist joe = new Cursist { Voornaam = "Joe", Familienaam = "Dalton" };
                Cursist averell = new Cursist { Voornaam = "Averell", Familienaam = "Dalton", Mentor = joe };
                context.Cursisten.Add(joe);
                context.Cursisten.Add(averell);
                context.SaveChanges();
                
                //var campus = new Campus
                //{
                //    Naam = "Delos",
                //    Adres = new Adres { Straat = "Vlamingstraat", HuisNr = "10", Postcode = "8560", Gemeente = "Wevelgem" }
                //};
                //var jean = new Instructeur
                //{
                //    Voornaam = "Jean",
                //    Familienaam = "Smits",
                //    Wedde = 1000,
                //    InDienst = new DateTime(1966, 8, 1),
                //    HeeftRijbewijs = true,
                //    Adres = new Adres { Straat = "Keizerlaan", HuisNr = "11", Postcode = "1000", Gemeente = "Brussel" },
                //    Campus = campus
                //};
                //context.Campussen.Add(campus);
                //context.Instructeurs.Add(jean);

                //var verantwoordelijkheid = new Verantwoordelijkheid { Naam = "EHBO" };
                //jean.Verantwoordelijkheden = new List<Verantwoordelijkheid> { verantwoordelijkheid };
                //context.Verantwoordelijkheden.Add(verantwoordelijkheid);

                //context.SaveChanges();

                
                //context.Cursussen.Add(new KlassikaleCursus { Naam = "Frans in 24 uur", Van = DateTime.Today, Tot = DateTime.Today });
                //context.Cursussen.Add(new ZelfstudieCursus { Naam = "Engels in 24 uur", AantalDagen = 1 });
                //context.SaveChanges();
                
                //var jean = new Instructeur
                //{
                //    Voornaam = "Jean",
                //    Familienaam = "Smits",
                //    Wedde = 1000,
                //    InDienst = new DateTime(1966, 8, 1),
                //    HeeftRijbewijs = true,
                //    Adres = new Adres { Straat = "Keizerlaan", HuisNr = "11", Postcode = "1000", Gemeente = "Brussel"}
                //};
                //context.Instructeurs.Add(jean);
                //context.SaveChanges();
                //Console.WriteLine(jean.InstructeurNr);
                //// zoeken op primary key
                //Console.WriteLine(context.Instructeurs.Find(1).Familienaam);
            }
        }
    }
}
