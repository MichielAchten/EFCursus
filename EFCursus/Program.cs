﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            //stored procedures voorbeeld 4
            //Console.Write("Familienaam: ");
            //var familienaam = Console.ReadLine();
            //using (var entities = new OpleidingenEntities())
            //{
            //    var aantalDocenten = entities.AantalDocentenMetFamilienaam(familienaam);
            //    Console.WriteLine("{0} docent(en)", aantalDocenten.First());
            //}
            
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from docent in entities.Docenten
            //                select docent;
            //    foreach (var docent in query)
            //    {
            //        int wedde = (int)docent.Wedde;
            //        int bovengrens = 0;
            //        int ondergrens = 0;
            //        int teller = wedde;
            //        for (int i = teller; i < teller + 100; i++)
            //        {
            //            if (i % 100 == 0)
            //            {
            //                bovengrens = i;
            //                break;
            //            }
            //        }
            //        teller = wedde;
            //        for (int i = teller; i > teller - 100; i--)
            //        {
            //            if (i % 100 == 0)
            //            {
            //                ondergrens = i;
            //                break;
            //            }
            //        }
            //        if ((bovengrens - wedde) < (wedde - ondergrens))
            //        {
            //            wedde = bovengrens;
            //        }
            //        else
            //        {
            //            wedde = ondergrens;
            //        }
            //        docent.Wedde = (decimal)wedde;
            //    }
            //    entities.SaveChanges();
            //}
            
            //stored procedures voorbeeld 3
            //Console.Write("Opslagpercentage: ");
            //decimal percentage;
            //if (decimal.TryParse(Console.ReadLine(), out percentage))
            //{
            //    using (var entities = new OpleidingenEntities())
            //    {
            //        var aantalDocentenAangepast = entities.WeddeVerhoging(percentage);
            //        Console.WriteLine("{0} docenten aangepast", aantalDocentenAangepast);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Tik een getal");
            //}
            
            //stored procedures voorbeeld 2
            //using (var entities = new OpleidingenEntities())
            //{
            //    foreach (var voornaamAantal in entities.AantalDocentenPerVoornaam())
            //    {
            //        Console.WriteLine("{0} {1}", voornaamAantal.Voornaam, voornaamAantal.Aantal);
            //    }
            //}
            
            //stored procedures voorbeeld 1
            //using (var entities = new OpleidingenEntities())
            //{
            //    foreach (var campus in entities.CampussenVanTotPostCode("8000", "8999"))
            //    {
            //        Console.WriteLine("{0}: {1}", campus.Naam, campus.PostCode);
            //    }
            //}
            
            //views
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from bestBetaaldeDocentPerCampus in entities.BestBetaaldeDocentenPerCampus
            //                orderby bestBetaaldeDocentPerCampus.CampusNr,
            //                    bestBetaaldeDocentPerCampus.Voornaam,
            //                    bestBetaaldeDocentPerCampus.Familienaam
            //                select bestBetaaldeDocentPerCampus;
            //    var vorigCampusNr = 0;
            //    foreach (var bestBetaaldeDocentPerCampus in query)
            //    {
            //        if (bestBetaaldeDocentPerCampus.CampusNr != vorigCampusNr)
            //        {
            //            Console.WriteLine("{0} {1} Grootste wedde: ", bestBetaaldeDocentPerCampus.Naam, bestBetaaldeDocentPerCampus.GrootsteWedde);
            //            vorigCampusNr = bestBetaaldeDocentPerCampus.CampusNr;
            //        }
            //        Console.WriteLine("\t{0} {1}", bestBetaaldeDocentPerCampus.Voornaam, bestBetaaldeDocentPerCampus.Familienaam);
            //    }
            //}
            
            //enums voorbeeld 2
            //using (var entities = new OpleidingenEntities())
            //{
            //    entities.Docenten.Add(
            //        new Docent { Naam = new Naam { Voornaam = "Brigitta", Familienaam = "Roos" },
            //            Wedde = 2000, Geslacht = Geslacht.Vrouw, CampusNr = 1 });
            //    entities.SaveChanges();
            //}

            //enums voorbeeld 1
            //using (var entities = new OpleidingenEntities())
            //{
            //    foreach (var docent in entities.Docenten)
            //    {
            //        Console.WriteLine("{0}:{1}", docent.Naam, docent.Geslacht);
            //    }
            //}
            
            //complex types
            //using (var entities = new OpleidingenEntities())
            //{
            //    foreach (var cursist in (from eenCursist in entities.Cursisten select eenCursist))
            //    {
            //        Console.WriteLine(cursist.Naam.InformeleBegroeting);
            //    }
            //}

            //inheritance (TPT) voorbeeld 3
            //using (var entities = new OpleidingenEntities())
            //{
            //    entities.Cursussen.Add(new ZelfstudieCursus { Naam = "Italiaanse correspondentie", Duurtijd = 6 });
            //    entities.SaveChanges();
            //}
            
            //inheritance (TPT) voorbeeld 2
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from cursus in entities.Cursussen
            //                where !(cursus is ZelfstudieCursus)
            //                orderby cursus.Naam
            //                select cursus;
            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine(cursus.Naam);
            //    }
            //}
            
            //inheritance (TPT) voorbeeld 1
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from cursus in entities.Cursussen
            //                orderby cursus.Naam
            //                select cursus;
            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine("{0}: {1}", cursus.Naam, cursus.GetType().Name);
            //    }
            //}
            
            //inheritance (TPH) voorbeeld 3
            //using (var entities = new OpleidingenEntities())
            //{
            //    entities.Cursussen.Add(new ZelfstudieCursus { Naam = "Duitse correspontentie", Duurtijd = 6 });
            //    entities.SaveChanges();
            //}
            
            //inheritance (TPH) voorbeeld 2
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from cursus in entities.Cursussen
            //                where cursus is ZelfstudieCursus
            //                orderby cursus.Naam
            //                select cursus;
            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine(cursus.Naam);
            //    }
            //}
            
            //inheritance (TPH) voorbeeld 1
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from cursus in entities.Cursussen
            //                orderby cursus.Naam
            //                select cursus;
            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine("{0}: {1}", cursus.Naam, cursus.GetType().Name);
            //    }
            //}
            
            //inheritance (TPC) voorbeeld 3
            //using (var entities = new OpleidingenEntities())
            //{
            //    entities.Cursussen.Add(new ZelfstudieCursus { Naam = "Spaanse Correspondentie", Duurtijd = 6 });
            //    entities.SaveChanges();
            //}

            //inheritance (TPC) voorbeeld 2
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from cursus in entities.Cursussen
            //                where cursus is KlassikaleCursus
            //                orderby cursus.Naam
            //                select cursus;
            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine(cursus.Naam);
            //    }
            //}
            
            //inheritance (TPC) voorbeeld 1
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from cursus in entities.Cursussen
            //                orderby cursus.Naam
            //                select cursus;
            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine(cursus.Naam + ' ' + cursus.GetType().Name);
            //    }
            //}
            
            //associaties (van een entity class naar zichzelf): voorbeeld 4
            //using (var entities = new OpleidingenEntities())
            //{
            //    var cursist5 = entities.Cursisten.Find(5);
            //    if (cursist5 != null)
            //    {
            //        var cursist6 = entities.Cursisten.Find(6);
            //        if (cursist6 != null)
            //        {
            //            cursist5.Beschermelingen.Add(cursist6);
            //            entities.SaveChanges();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Cursist 6 niet gevonden");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Cursist 5 niet gevonden");
            //    }
            //}
            
            //associaties (van een entity class naar zichzelf): voorbeeld 3
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from mentor in entities.Cursisten.Include("Beschermelingen")
            //                where mentor.Beschermelingen.Count != 0
            //                orderby mentor.Voornaam, mentor.Familienaam
            //                select mentor;
            //    foreach (var mentor in query)
            //    {
            //        Console.WriteLine("{0} {1}", mentor.Voornaam, mentor.Familienaam);
            //        foreach (var beschermeling in mentor.Beschermelingen)
            //        {
            //            Console.WriteLine("\t{0} {1}", beschermeling.Voornaam, beschermeling.Familienaam);
            //        }
            //    }
            //}
            
            //associaties (van een entity class naar zichzelf): voorbeeld 2
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from cursist in entities.Cursisten.Include("Mentor")
            //                where cursist.Mentor != null
            //                orderby cursist.Voornaam, cursist.Familienaam
            //                select cursist;
            //    foreach (var cursist in query)
            //    {
            //        var mentor = cursist.Mentor;
            //        Console.WriteLine("{0} {1}: {2} {3}", cursist.Voornaam, cursist.Familienaam, mentor.Voornaam, mentor.Familienaam);
            //    }
            //}
            
            //associaties (van een entity class naar zichzelf): voorbeeld 1
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from cursist in entities.Cursisten
            //                where cursist.Mentor == null
            //                orderby cursist.Voornaam, cursist.Familienaam
            //                select cursist;
            //    foreach (var cursist in query)
            //    {
            //        Console.WriteLine("{0} {1}", cursist.Voornaam, cursist.Familienaam);
            //    }
            //}

            //associaties (veel op veel associaties met associatie-informatie): voorbeeld 2
            //var nieuwBoek = new Boek() { ISBNNr = "0-201-70431-5", Titel = "Modern C++ Design" };
            //var transactionOptions = new TransactionOptions { IsolationLevel = IsolationLevel.Serializable };
            //using (var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions))
            //{
            //    using (var entities = new OpleidingenEntities())
            //    {
            //        var query = from cursus in entities.Cursussen.Include("BoekenCursussen")
            //                    where cursus.Naam == "C++"
            //                    select new { Cursus = cursus, HoogsteVolgNr = cursus.BoekenCursussen.Max(boekCursus => boekCursus.VolgNr) };
            //        var queryResult = query.FirstOrDefault();
            //        if (queryResult != null)
            //        {
            //            entities.BoekenCursussen.Add(new BoekCursus
            //            {
            //                Boek = nieuwBoek,
            //                Cursus = queryResult.Cursus,
            //                VolgNr = queryResult.HoogsteVolgNr + 1
            //            });
            //            entities.SaveChanges();
            //        }
            //        transactionScope.Complete();
            //    }
            //}

            //associaties (veel op veel associaties met associatie-informatie): voorbeeld 1
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query =
            //        from cursus in entities.Cursussen.Include("BoekenCursussen.Boek")
            //        orderby cursus.Naam
            //        select cursus;
            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine(cursus.Naam);
            //        foreach (var boekCursus in cursus.BoekenCursussen)
            //        {
            //            Console.WriteLine("\t{0}:{1}", boekCursus.VolgNr, boekCursus.Boek.Titel);
            //        }
            //    }
            //}

            //associaties (veel op veel associaties zonder associatie-informatie): voorbeeld 3
            //using (var entities = new OpleidingenEntities())
            //{
            //    var nieuwBoek = new Boek { ISBNNr = "0-0788210-6-1", Titel = "Oracle Backup & Recovery Handbook" };
            //    var oracleCursus = (from cursus in entities.Cursussen
            //                        where cursus.Naam == "Oracle"
            //                        select cursus).FirstOrDefault();
            //    if (oracleCursus != null)
            //    {
            //        oracleCursus.Boeken.Add(nieuwBoek);
            //        entities.SaveChanges();
            //    }
            //    else
            //    {
            //        Console.WriteLine("cursus Oracle niet gevonden");
            //    }
            //}

            //associaties (veel op veel associaties zonder associatie-informatie): voorbeeld 2
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from cursus in entities.Cursussen.Include("Boeken")
            //                orderby cursus.Naam
            //                select cursus;
            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine(cursus.Naam);
            //        foreach (var boek in cursus.Boeken)
            //        {
            //            Console.WriteLine("\t{0}", boek.Titel);
            //        }
            //    }
            //}

            //associaties (veel op veel associaties zonder associatie-informatie): voorbeeld 1
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from boek in entities.Boeken.Include("Cursussen")
            //                orderby boek.Titel
            //                select boek;
            //    foreach (var boek in query)
            //    {
            //        Console.WriteLine(boek.Titel);
            //        foreach (var cursus in boek.Cursussen)
            //        {
            //            Console.WriteLine("\t{0}", cursus.Naam);
            //        }
            //    }
            //}
            
            //voorbeeld optimistic record locking
        //    try
        //    {
        //        Console.Write("Artikel nr.: ");
        //        var artikelNr = int.Parse(Console.ReadLine());
        //        Console.Write("Magazijn nr.: ");
        //        var magazijnNr = int.Parse(Console.ReadLine());
        //        Console.Write("Aantal stuks toevoegen: ");
        //        var aantalStuks = int.Parse(Console.ReadLine());
        //        new Program().VoorraadBijvulling(artikelNr, magazijnNr, aantalStuks);
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Tik een getal");
        //    }
        //}

        //public void VoorraadBijvulling(int artikelNr, int magazijnNr, int aantalStuks)
        //{
        //    using (var entities = new OpleidingenEntities())
        //    {
        //        var voorraad = entities.Voorraden.Find(magazijnNr, artikelNr);
        //        if (voorraad != null)
        //        {
        //            voorraad.AantalStuks += aantalStuks;
        //            Console.WriteLine("Pas nu de voorraad aan met de Server Explorer, druk daarna op enter");
        //            Console.ReadLine();
        //            try
        //            {
        //                entities.SaveChanges();
        //            }
        //            catch (DbUpdateConcurrencyException)
        //            {
        //                Console.WriteLine("Voorraad werd door andere applicatie aangepast");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Voorraad niet gevonden");
        //        }
        //    }

        //transactions
        //    try
        //    {
        //        Console.Write("Artikel nr.: ");
        //        var artikelNr = int.Parse(Console.ReadLine());
        //        Console.Write("Van magazijn nr.: ");
        //        var vanMagazijnNr = int.Parse(Console.ReadLine());
        //        Console.Write("Naar magazijn nr.: ");
        //        var naarMagazijnNr = int.Parse(Console.ReadLine());
        //        Console.Write("Aantal stuks: ");
        //        var aantalStuks = int.Parse(Console.ReadLine());
        //        new Program().VoorraadTransfer(artikelNr, vanMagazijnNr, naarMagazijnNr, aantalStuks);
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Tik een getal");
        //    }
        //}
        //void VoorraadTransfer(int artikelNr, int vanMagazijnNr, int naarMagazijnNr, int aantalStuks)
        //{
        //    var transactionOptions = new TransactionOptions { IsolationLevel = IsolationLevel.RepeatableRead }; //bijgevoegd
        //    using (var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions))    //bijgevoegd
        //    {
        //        using (var entities = new OpleidingenEntities())
        //        {
        //            var vanVoorraad = entities.Voorraden.Find(vanMagazijnNr, artikelNr);
        //            if (vanVoorraad != null)
        //            {
        //                if (vanVoorraad.AantalStuks >= aantalStuks)
        //                {
        //                    vanVoorraad.AantalStuks -= aantalStuks;
        //                    var naarVoorraad = entities.Voorraden.Find(naarMagazijnNr, artikelNr);
        //                    if (naarVoorraad != null)
        //                    {
        //                        naarVoorraad.AantalStuks += aantalStuks;
        //                    }
        //                    else
        //                    {
        //                        naarVoorraad = new Voorraad { ArtikelNr = artikelNr, MagazijnNr = naarMagazijnNr, AantalStuks = aantalStuks };
        //                        entities.Voorraden.Add(naarVoorraad);
        //                    }
        //                    entities.SaveChanges();
        //                    transactionScope.Complete();    //bijgevoegd
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Te weinig voorraad voor transfer");
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine("Artikel niet gevonden in magazijn {0}", vanMagazijnNr);
        //            }
        //        }
        //    }

            //entitie verwijderen
            //Console.Write("Nummer docent: ");
            //int docentNr;
            //if (int.TryParse(Console.ReadLine(), out docentNr))
            //{
            //    using (var entities = new OpleidingenEntities())
            //    {
            //        var docent = entities.Docenten.Find(docentNr);
            //        if (docent != null)
            //        {
            //            entities.Docenten.Remove(docent);
            //            entities.SaveChanges();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Docent niet gevonden");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Tik een getal");
            //}
            
            //associaties wijzigen aan de veel kant
            //using (var entities = new OpleidingenEntities())
            //{
            //    var docent1 = entities.Docenten.Find(1);
            //    if (docent1 != null)
            //    {
            //        var campus3 = entities.Campussen.Find(3);
            //        if (campus3 != null)
            //        {
            //            campus3.Docenten.Add(docent1);
            //            entities.SaveChanges();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Campus 3 niet gevonden");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Docent 1 niet gevonden");
            //    }
            //}
            
            //associatie wijzigen aan de veel kant:
            //te associëren entity associëren met de foreign key property
            //using (var entities = new OpleidingenEntities())
            //{
            //    var docent1 = entities.Docenten.Find(1);
            //    if (docent1 != null)
            //    {
            //        docent1.CampusNr = 2;
            //        entities.SaveChanges();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Docent 1 niet gevonden");
            //    }
            //}
            
            //associatie wijzigen aan veel kant:
            //te associëren entity lezen en associëren aan de te wijzigen entity
            //using (var entities = new OpleidingenEntities())
            //{
            //    var docent1 = entities.Docenten.Find(1);
            //    if (docent1 != null)
            //    {
            //        var campus6 = entities.Campussen.Find(6);
            //        if (campus6 != null)
            //        {
            //            docent1.Campus = campus6;
            //            entities.SaveChanges();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Campus 6 niet gevonden");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Docent 1 niet gevonden");
            //    }
            //}
            
            //entities wijzigen die je indirect gelezen hebt met associaties
            //using (var entities = new OpleidingenEntities())
            //{
            //    var campus1 = entities.Campussen.Find(1);
            //    if (campus1 != null)
            //    {
            //        foreach (var docent in campus1.Docenten)
            //        {
            //            docent.Opslag(10m);
            //        }
            //        entities.SaveChanges();
            //    }
            //}
            
            //meerdere entities lezen en slechts enkele daarvan wijzigen
            //using (var entities = new OpleidingenEntities())
            //{
            //    var docent1 = entities.Docenten.Find(1);
            //    var docent2 = entities.Docenten.Find(2);
            //    docent2.Opslag(10m);
            //    entities.SaveChanges();
            //}
            
            //één entity wijzigen
            //Console.Write("DocentNr.: ");
            //int docentNr;
            //if (int.TryParse(Console.ReadLine(), out docentNr))
            //{
            //    using (var entities = new OpleidingenEntities())
            //    {
            //        var docent = entities.Docenten.Find(docentNr);
            //        if (docent != null)
            //        {
            //            Console.WriteLine("Wedde:{0}", docent.Wedde);
            //            Console.Write("Bedrag: ");
            //            decimal bedrag;
            //            if (decimal.TryParse(Console.ReadLine(), out bedrag))
            //            {
            //                docent.Opslag(bedrag);
            //                entities.SaveChanges();
            //            }
            //            else
            //            {
            //                Console.WriteLine("Tik een getal");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Docent niet gevonden");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Tik een getal");
            //}
            
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
