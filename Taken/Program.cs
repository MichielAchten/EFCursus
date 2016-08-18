using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taken
{
    class Program
    {
        static void Main(string[] args)
        {


            //1.4 storten
            //using (var entities = new BankEntities())
            //{
            //    Console.Write("Rekeningnummer: ");
            //    string rekeningNr = Console.ReadLine();
            //    var rekening = entities.Rekeningen.Find(rekeningNr);
            //    if (rekening != null)
            //    {
            //        Console.Write("Bedrag: ");
            //        decimal bedrag;
            //        if (decimal.TryParse(Console.ReadLine(), out bedrag))
            //        {
            //            if (bedrag > 0m)
            //            {
            //                rekening.Storten(bedrag);
            //                entities.SaveChanges();
            //            }
            //            else
            //            {
            //                Console.WriteLine("Tik een positief getal");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Tik een getal");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Rekening niet gevonden");
            //    }
            //}
            
            //1.3 zichtrekening toevoegen(voorbeeldoplossing)
            //using (var entities = new BankEntities())
            //{
            //    var query = from klant in entities.Klanten
            //                orderby klant.Voornaam
            //                select klant;
            //    foreach (var klant in query)
            //    {
            //        Console.WriteLine("{0}: {1}", klant.KlantNr, klant.Voornaam);
            //    }
            //    try
            //    {
            //        Console.Write("KlantNr: ");
            //        var klantNr = int.Parse(Console.ReadLine());
            //        var klant = entities.Klanten.Find(klantNr);
            //        if (klant == null)
            //        {
            //            Console.WriteLine("Klant niet gevonden");
            //        }
            //        else
            //        {
            //            Console.Write("RekeningNr: ");
            //            var rekeningNr = Console.ReadLine();
            //            var rekening = new Rekening { RekeningNr = rekeningNr, Soort = "Z" };
            //            klant.Rekeningen.Add(rekening);
            //            entities.SaveChanges();
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Tik een getal");
            //    }
            //}
            
            //1.3 zichtrekening toevoegen(eigen oplossing)
            //List<Klant> klanten;
            //using (var entities = new BankEntities())
            //{
            //    var query = from klant in entities.Klanten.Include("Rekeningen")
            //                orderby klant.Voornaam
            //                select klant;
            //    klanten = query.ToList();
            //}
            //foreach (var eenKlant in klanten)
            //{
            //    Console.WriteLine("{0}: {1}", eenKlant.KlantNr, eenKlant.Voornaam);
            //}
            //Console.Write("KlantNr: ");
            //int gekozenKlant;
            //if (Int32.TryParse(Console.ReadLine(), out gekozenKlant))
            //{
            //    using (var entities = new BankEntities())
            //    {
            //        var klant = entities.Klanten.Find(gekozenKlant);
            //        if (klant != null)
            //        {
            //            Console.Write("Rekeningnummer nieuwe rekening: ");
            //            string nieuweRekeningNr = Console.ReadLine();
            //            var nieuweRekening = new Rekening { RekeningNr = nieuweRekeningNr, Saldo = 0, Soort = "Z" , KlantNr = gekozenKlant};
            //            entities.Rekeningen.Add(nieuweRekening);
            //            entities.SaveChanges();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Klant niet gevonden");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Tik een getal");
            //}

            //1.2 Klanten en hun rekeningen
            //List<Klant> klanten;
            //using (var entities = new BankEntities())
            //{
            //    var query = from klant in entities.Klanten.Include("Rekeningen")
            //                orderby klant.Voornaam
            //                select klant;
            //    klanten = query.ToList();
            //}
            //foreach (var eenKlant in klanten)
            //{
            //    decimal totaal = Decimal.Zero;
            //    Console.WriteLine(eenKlant.Voornaam);
            //    //if (eenKlant.Rekeningen != null)
            //    //{
            //        foreach (var eenRekening in eenKlant.Rekeningen)
            //        {
            //            Console.WriteLine("{0}: {1}", eenRekening.RekeningNr, eenRekening.Saldo);
            //            totaal += eenRekening.Saldo;
            //        }
            //    //}
            //    Console.WriteLine("Totaal: {0}", totaal);
            //    Console.WriteLine();
            //}
        }
    }
}
