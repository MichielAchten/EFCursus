using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Taken
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.8 personeel: voorbeeldoplossing
        //    using (var entities = new BankEntities())
        //    {
        //        var hoogstenInHierarchie = (from personeelslid in entities.Personeel
        //                                    where personeelslid.Manager == null
        //                                    select personeelslid).ToList();
        //        new Program().Afbeelden(hoogstenInHierarchie, 0);
        //    }
        //}
        //public void Afbeelden(List<Personeelslid> personeel, int insprong)
        //{
        //    foreach (var personeelslid in personeel)
        //    {
        //        Console.Write(new string('\t', insprong));
        //        Console.WriteLine(personeelslid.Voornaam);
        //        if (personeelslid.Ondergeschikten.Count != 0)
        //        {
        //            Afbeelden(personeelslid.Ondergeschikten.ToList(), insprong + 1);
        //        }
        //    }

            //1.8 personeel: eigen oplossing
            //using (var entities = new BankEntities())
            //{
            //    var query = from personeelslid in entities.Personeel.Include("Ondergeschikten")
            //                where personeelslid.ManagerNr == null
            //                orderby personeelslid.Voornaam
            //                select personeelslid;
            //    foreach (var manager in query)
            //    {
            //        Console.WriteLine("{0}", manager.Voornaam);
            //        foreach (var ondergeschikte in manager.Ondergeschikten)
            //        {
            //            Console.WriteLine("\t{0}", ondergeschikte.Voornaam);
            //            foreach (var ondergeschikte2 in ondergeschikte.Ondergeschikten)
            //            {
            //                Console.WriteLine("\t\t{0}", ondergeschikte2.Voornaam);
            //                foreach (var ondergeschikte3 in ondergeschikte2.Ondergeschikten)
            //                {
            //                    Console.WriteLine("\t\t\t{0}", ondergeschikte3.Voornaam);
            //                }
            //            }
            //        }
            //    }
            //}
            
            //1.7 klant wijzigen: voorbeeldoplossing
            //Console.Write("KlantNr: ");
            //try
            //{
            //    var klantNr = int.Parse(Console.ReadLine());
            //    using (var entities = new BankEntities())
            //    {
            //        var klant = entities.Klanten.Find(klantNr);
            //        if (klant == null)
            //        {
            //            Console.WriteLine("Klant niet gevonden");
            //        }
            //        else
            //        {
            //            Console.Write("Voornaam: ");
            //            klant.Voornaam = Console.ReadLine();
            //            entities.SaveChanges();
            //        }
            //    }
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    Console.WriteLine("Een andere gebruiker wijzigde deze klant");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Tik een getal");
            //}
            
            //1.7 klant wijzigen: eigen oplossing
            //Console.Write("KlantNr.: ");
            //try
            //{
            //    var klantNr = int.Parse(Console.ReadLine());
            //    using (var entities = new BankEntities())
            //    {
            //        var klant = entities.Klanten.Find(klantNr);
            //        if (klant != null)
            //        {
            //            Console.Write("Gecorigeerde naam klant: ");
            //            var nieuweNaam = Console.ReadLine();
            //            klant.Voornaam = nieuweNaam;
            //            Console.WriteLine("Pas nu de naam aan in de ServerExplorer, druk daarna op Enter");
            //            Console.ReadLine();
            //            try
            //            {
            //                entities.SaveChanges();
            //            }
            //            catch (DbUpdateConcurrencyException)
            //            {
            //                Console.WriteLine("Een andere gebruiker wijzigde deze klant");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Klant niet gevonden");
            //        }
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Tik een getal");
            //}
            
            //1.6 overschrijven: voorbeeldoplossing (zie ook Rekening)
            //Console.Write("RekeningNr. van rekening: ");
            //var vanRekeningNr = Console.ReadLine();
            //Console.Write("RekeningNr. naar rekening: ");
            //var naarRekeningNr = Console.ReadLine();
            //try
            //{
            //    Console.Write("Bedrag: ");
            //    var bedrag = decimal.Parse(Console.ReadLine());
            //    if (bedrag <= decimal.Zero)
            //    {
            //        Console.WriteLine("Tik een positief bedrag");
            //    }
            //    else
            //    {
            //        var transactionOptions = new TransactionOptions { IsolationLevel = IsolationLevel.RepeatableRead };
            //        using (var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions))
            //        {
            //            using (var entities = new BankEntities())
            //            {
            //                var vanRekening = entities.Rekeningen.Find(vanRekeningNr);
            //                if (vanRekening == null)
            //                {
            //                    Console.WriteLine("Van rekening niet gevonden");
            //                }
            //                else
            //                {
            //                    var naarRekening = entities.Rekeningen.Find(naarRekeningNr);
            //                    if (naarRekening == null)
            //                    {
            //                        Console.WriteLine("Naar rekening niet gevonden");
            //                    }
            //                    else
            //                    {
            //                        try
            //                        {
            //                            vanRekening.Overschrijven(naarRekening, bedrag);
            //                            entities.SaveChanges();
            //                            transactionScope.Complete();
            //                        }
            //                        catch (SaldoOntoereikendException)
            //                        {
            //                            Console.WriteLine("Saldo ontoereikend");
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Tik een bedrag");
            //}
            
            //1.6 overschrijven: eigen oplossing
        //    try
        //    {
        //        Console.Write("Van rekening: ");
        //        var vanRekeningNr = Console.ReadLine();
        //        Console.Write("Naar Rekening: ");
        //        var naarRekeningNr = Console.ReadLine();
        //        Console.Write("Bedrag: ");
        //        var bedrag = decimal.Parse(Console.ReadLine());
        //        if (bedrag > 0)
        //        {
        //            new Program().Overschrijven(vanRekeningNr, naarRekeningNr, bedrag);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Tik een positief bedrag");
        //        }
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Tik een getal");
        //    }
            
        //}
    
        //public void Overschrijven(string vanRekeningNr, string naarRekeningNr, decimal bedrag)
        //{
        //    using (var entities = new BankEntities())
        //    {
        //        var vanRekening = entities.Rekeningen.Find(vanRekeningNr);
        //        if (vanRekening != null)
        //        {
        //            if (vanRekening.Saldo >= bedrag)
        //            {
        //                vanRekening.Saldo -= bedrag;
        //                var naarRekening = entities.Rekeningen.Find(naarRekeningNr);
        //                if (naarRekening != null)
        //                {
        //                    naarRekening.Saldo += bedrag;
        //                    entities.SaveChanges();
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Naar rekening niet gevonden");
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine("Saldo ontoereikend");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Naar rekening niet gevonden");
        //        }
        //    }
            
            
            //1.5 klant verwijderen
            //Console.Write("klantnummer: ");
            //int klantNr;
            //if (int.TryParse(Console.ReadLine(), out klantNr))
            //{
            //    using (var entities = new BankEntities())
            //    {
            //        var klant = entities.Klanten.Find(klantNr);
            //        if (klant != null)
            //        {

            //            if (klant.Rekeningen.Count == 0)
            //            {
            //                entities.Klanten.Remove(klant);
            //                entities.SaveChanges();
            //            }
            //            else
            //            {
            //                Console.WriteLine("Klant heeft nog rekeningen, dus kan niet verwijderd worden");
            //            }
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
            ////eerst klant toevoegen
            //var klant = new Klant { KlantNr = 6, Voornaam = "NieuweKlant1" };
            //using (var entities = new BankEntities())
            //{
            //    entities.Klanten.Add(klant);
            //    entities.SaveChanges();
            //}
            ////rekening verwijderen
            //string rekeningNr = "333-3333333-11";
            //using (var entities = new BankEntities())
            //{
            //    var rekening = entities.Rekeningen.Find(rekeningNr);
            //    if (rekening != null)
            //    {
            //        entities.Rekeningen.Remove(rekening);
            //        entities.SaveChanges();
            //    }
            //}

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
