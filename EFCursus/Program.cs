using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            //entity toevoegen met een associatie naar een bestaande entity vanuit de één kant
            //var docent5 = new Docent { Voornaam = "Voornaam5", Familienaam = "Familienaam5", Wedde = 5 };
            //using (var entities = new OpleidingenEntities())
            //{
            //    var campus1 = entities.Campussen.Find(1);
            //    if (campus1 != null)
            //    {
            //        campus1.Docenten.Add(docent5);
            //        entities.SaveChanges();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Campus 1 niet gevonden");
            //    }
            //}

            //entity toevoegen met een associatie naar een bestaande entity vanuit de veel kant (entity koppelen met de foreign key property)
            //var docent4 = new Docent { Voornaam = "Voornaam4", Familienaam = "Familienaam4", Wedde = 4, CampusNr = 1 };
            //using (var entities = new OpleidingenEntities())
            //{
            //    entities.Docenten.Add(docent4);
            //    entities.SaveChanges();
            //}

            //entity toevoegen met een associatie naar een bestaande entity vanuit de veel kant (entity lezen en associëren aan de nieuwe entity)
            //var docent3 = new Docent { Voornaam = "Voornaam3", Familienaam = "Familienaam3", Wedde = 3 };
            //using (var entities = new OpleidingenEntities())
            //{
            //    var campus1 = entities.Campussen.Find(1);
            //    if (campus1 != null)
            //    {
            //        entities.Docenten.Add(docent3);
            //        docent3.Campus = campus1;
            //        entities.SaveChanges();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Campus 1 niet gevonden");
            //    }
            //}

            //entities met nieuwe geassocieerde entities toevoegen
            //var campus5 = new Campus { Naam = "Naam5", Straat = "Straat5", HuisNr = "5", PostCode = "5555", Gemeente = "Gemeente5" };
            //var docent2 = new Docent { Voornaam = "Voornaam2", Familienaam = "Familienaam2", Wedde = 2 };
            //docent2.Campus = campus5;
            //using (var entities = new OpleidingenEntities())
            //{
            //    entities.Docenten.Add(docent2);
            //    entities.SaveChanges();
            //}
            
            //entities met nieuwe geassocieerde entities toevoegen
            //var campus4 = new Campus { Naam = "Naam4", Straat = "Straat4", HuisNr = "4", PostCode = "4444", Gemeente = "Gemeente4" };
            //var docent1 = new Docent { Voornaam = "Voornaam1", Familienaam = "Familienaam1", Wedde = 1 };
            //campus4.Docenten.Add(docent1);
            //using (var entities = new OpleidingenEntities())
            //{
            //    entities.Campussen.Add(campus4);
            //    entities.SaveChanges();
            //}
            
            //meerdere entities toevoegen
            //var campus2 = new Campus { Naam = "Naam2", Straat = "Straat2", HuisNr = "2", PostCode = "2222", Gemeente = "Gemeente2" };
            //var campus3 = new Campus { Naam = "Naam3", Straat = "Straat3", HuisNr = "3", PostCode = "3333", Gemeente = "Gemeente3" };
            //using (var entities = new OpleidingenEntities())
            //{
            //    entities.Campussen.Add(campus2);
            //    entities.Campussen.Add(campus3);
            //    entities.SaveChanges();
            //    Console.WriteLine(campus2.CampusNr);
            //    Console.WriteLine(campus3.CampusNr);
            //}

            //query en ToList() in één method
        //    Program program = new Program();
        //    foreach (var campus in program.FindAllCampussen())
        //    {
        //        Console.WriteLine(campus.Naam);
        //    }
        //}
        
        //List<Campus> FindAllCampussen()
        //{
        //    using (var entities = new OpleidingenEntities())
        //    {
        //        return (from campus in entities.Campussen
        //                orderby campus.Naam
        //                select campus).ToList();
        //    }
            

            //method ToList()
            //List<Campus> campussen;
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from campus in entities.Campussen
            //                orderby campus.Naam
            //                select campus;
            //    campussen = query.ToList();
            //}
            //foreach (var campus in campussen)
            //{
            //    Console.WriteLine(campus.Naam);
            //}
            //Console.WriteLine();
            //foreach (var campus in campussen)
            //{
            //    Console.WriteLine(campus.Naam);
            //}
            
            //eager loading 2
            //using (var entities = new OpleidingenEntities())
            //{
            //    Console.Write("Deel naam campus:");
            //    var deelNaam = Console.ReadLine();
            //    var query = entities.Campussen.Include("Docenten")
            //        .Where(campus => campus.Naam.Contains(deelNaam))
            //        .OrderBy(campus => campus.Naam);
            //    //var query = from campus in entities.Campussen.Include("Docenten")
            //    //            where campus.Naam.Contains(deelNaam)
            //    //            orderby campus.Naam
            //    //            select campus;
            //    foreach (var campus in query)
            //    {
            //        var campusNaam = campus.Naam;
            //        Console.WriteLine(campusNaam);
            //        Console.WriteLine(new string('-', campusNaam.Length));
            //        foreach (var docent in campus.Docenten)
            //        {
            //            Console.WriteLine(docent.Naam);
            //        }
            //        Console.WriteLine();
            //    }
            //}
            
            //eager loading
            //using (var entities = new OpleidingenEntities())
            //{
            //    Console.Write("Voornaam:");
            //    var voornaam = Console.ReadLine();
            //    var query = from docent in entities.Docenten.Include("Campus")
            //                where docent.Voornaam == voornaam
            //                select docent;
            //    foreach (var docent in query)
            //    {
            //        Console.WriteLine("{0}: {1}", docent.Naam, docent.Campus.Naam);
            //    }
            //}
            
            //lazy loading
            //using (var entities = new OpleidingenEntities())
            //{
            //    Console.Write("Voornaam:");
            //    var voornaam = Console.ReadLine();
            //    var query = from docent in entities.Docenten
            //                where docent.Voornaam == voornaam
            //                select docent;
            //    foreach (var docent in query)
            //    {
            //        Console.WriteLine("{0}: {1}", docent.Naam, docent.Campus.Naam);
            //    }
            //}
            
            //groeperen in queries
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = entities.Docenten
            //        .GroupBy((docent) => docent.Voornaam, (Voornaam, docenten) => new { Voornaam, VoornaamGroep = docenten });
            //    //var query = from docent in entities.Docenten
            //    //            group docent by docent.Voornaam into VoornaamGroup
            //    //            select new { VoornaamGroep, Voornaam = VoornaamGroep.Key };
            //    foreach (var voornaamStatistiek in query)
            //    {
            //        Console.WriteLine(voornaamStatistiek.Voornaam);
            //        Console.WriteLine(new string('-', voornaamStatistiek.Voornaam.Length));
            //        foreach (var docent in voornaamStatistiek.VoornaamGroep)
            //        {
            //            Console.WriteLine(docent.Naam);
            //        }
            //        Console.WriteLine();
            //    }
            //}
            
            //gedeeltelijke objecten ophalen
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = entities.Campussen
            //        .OrderBy(campus => campus.Naam)
            //        .Select(campus => new { campus.CampusNr, campus.Naam });
            //    //var query = from campus in entities.Campussen
            //    //            orderby campus.Naam
            //    //            select new { campus.CampusNr, campus.Naam };
            //    foreach (var campusDeel in query)
            //    {
            //        Console.WriteLine("{0}: {1}", campusDeel.CampusNr, campusDeel.Naam);
            //    }
            //}
            
            //entity zoeken op zijn primary key waarde
            //using (var entities = new OpleidingenEntities())
            //{
            //    Console.Write("DocentNr.:");
            //    int docentNr;
            //    if (int.TryParse(Console.ReadLine(), out docentNr))
            //    {
            //        var docent = entities.Docenten.Find(docentNr);
            //        Console.WriteLine(docent == null ? "Niet gevonden" : docent.Naam);
            //    }
            //    else
            //    {
            //        Console.WriteLine("U tikt geen getal");
            //    }
            //}

            //linq queries en queries met methods vergeleken
            //Console.Write("Minimum wedde:");
            //decimal minWedde;
            //if (decimal.TryParse(Console.ReadLine(), out minWedde))
            //{
            //    Console.WriteLine("Sorteren: 1 = op wedde, 2 = op familienaam, 3 = op voornaam:");
            //    var sorterenOp = Console.ReadLine();
            //    Func<Docent, Object> sorteerLambda;
            //    switch (sorterenOp)
            //    {
            //        case "1":
            //            sorteerLambda = (docent) => docent.Wedde;
            //            break;
            //        case "2":
            //            sorteerLambda = (docent) => docent.Familienaam;
            //            break;
            //        case "3":
            //            sorteerLambda = (docent) => docent.Voornaam;
            //            break;
            //        default:
            //            Console.WriteLine("Verkeerde keuze");
            //            sorteerLambda = null;
            //            break;
            //    }
            //    if (sorteerLambda != null)
            //    {
            //        using (var entities = new OpleidingenEntities())
            //        {
            //            var query = entities.Docenten
            //                .Where(docent => docent.Wedde > minWedde)
            //                .OrderBy(sorteerLambda);
            //            foreach (var docent in query)
            //            {
            //                Console.WriteLine("{0}: {1}", docent.Naam, docent.Wedde);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("U tikte geen getal");
            //    }
            //}
            
            //linq queries en queries met methods vergeleken
            //Console.Write("Minimum wedde:");
            //decimal minWedde;
            //if (decimal.TryParse(Console.ReadLine(), out minWedde))
            //{
            //    Console.WriteLine("Sorteren: 1 = op wedde, 2 = op familienaam, 3 = op voornaam:");
            //    var sorterenOp = Console.ReadLine();
            //    using(var entities = new OpleidingenEntities())
            //    {
            //        IQueryable<Docent> query;
            //        switch (sorterenOp)
            //        {
            //            case "1":
            //                query = from docent in entities.Docenten
            //                        where docent.Wedde >= minWedde
            //                        orderby docent.Wedde
            //                        select docent;
            //                break;
            //            case "2":
            //                query = from docent in entities.Docenten
            //                        where docent.Wedde >= minWedde
            //                        orderby docent.Familienaam
            //                        select docent;
            //                break;
            //            case "3":
            //                query = from docent in entities.Docenten
            //                        where docent.Wedde >= minWedde
            //                        orderby docent.Voornaam
            //                        select docent;
            //                break;
            //            default:
            //                Console.WriteLine("Verkeerde keuze");
            //                query = null;
            //                break;
            //        }
            //        if (query != null)
            //        {
            //            foreach (var docent in query)
            //            {
            //                Console.WriteLine("{0}: {1}", docent.Naam, docent.Wedde);
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("U tikte geen getal");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Tik een getal");
            //}
            
            //linq query en query methods
            //Console.Write("Minimum wedde:");
            //decimal minWedde;
            //if (decimal.TryParse(Console.ReadLine(), out minWedde))
            //{
            //    using (var entities = new OpleidingenEntities())
            //    {
            //        var query = entities.Docenten
            //            .Where(docent => docent.Wedde >= minWedde)
            //            .OrderBy(docent => docent.Voornaam)
            //            .ThenBy(docent => docent.Familienaam);

            //        //var query = from docent in entities.Docenten
            //        //            where docent.Wedde >= minWedde
            //        //            orderby docent.Voornaam, docent.Familienaam
            //        //            select docent;

            //        foreach (var docent in query)
            //        {
            //            Console.WriteLine("{0}: {1}", docent.Naam, docent.Wedde);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Tik een getal");
            //}
            
            //foreach iteratie
            //using (var entities = new OpleidingenEntities())
            //{
            //    foreach (var docent in entities.Docenten)
            //    {
            //        Console.WriteLine(docent.Naam);
            //    }
            //}
        }
    }
}
