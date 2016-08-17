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
            List<Klant> klanten;
            using (var entities = new BankEntities())
            {
                var query = from klant in entities.Klanten.Include("Rekeningen")
                            orderby klant.Voornaam
                            select klant;
                klanten = query.ToList();
            }
            foreach (var eenKlant in klanten)
            {
                decimal totaal = Decimal.Zero;
                Console.WriteLine(eenKlant.Voornaam);
                //if (eenKlant.Rekeningen != null)
                //{
                    foreach (var eenRekening in eenKlant.Rekeningen)
                    {
                        Console.WriteLine("{0}: {1}", eenRekening.RekeningNr, eenRekening.Saldo);
                        totaal += eenRekening.Saldo;
                    }
                //}
                Console.WriteLine("Totaal: {0}", totaal);
                Console.WriteLine();
            }
        }
    }
}
