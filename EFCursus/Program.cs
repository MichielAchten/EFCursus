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
