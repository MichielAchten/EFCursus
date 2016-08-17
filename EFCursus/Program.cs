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
            Console.WriteLine("Minimum wedde:");
            decimal minWedde;
            if (decimal.TryParse(Console.ReadLine(), out minWedde))
            {
                Console.WriteLine("Sorteren: 1 = op wedde, 2 = op familienaam, 3 = op voornaam:");
                var sorterenOp = Console.ReadLine();
                Func<Docent, Object> sorteerLambda;
                switch (sorterenOp)
                {
                    case "1":
                        sorteerLambda = (docent) => docent.Wedde;
                        break;
                    case "2":
                        sorteerLambda = (docent) => docent.Familienaam;
                        break;
                    case "3":
                        sorteerLambda = (docent) => docent.Voornaam;
                        break;
                    default:
                        Console.WriteLine("Verkeerde keuze");
                        sorteerLambda = null;
                        break;
                }
                if (sorteerLambda != null)
                {
                    using (var entities = new OpleidingenEntities())
                    {
                        var query = entities.Docenten
                            .Where(docent => docent.Wedde > minWedde)
                            .OrderBy(sorteerLambda);
                        foreach (var docent in query)
                        {
                            Console.WriteLine("{0}: {1}", docent.Naam, docent.Wedde);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("U tikte geen getal");
                }
            }
            
            //Console.WriteLine("Minimum wedde:");
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
            
            //Console.WriteLine("Minimum wedde:");
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
