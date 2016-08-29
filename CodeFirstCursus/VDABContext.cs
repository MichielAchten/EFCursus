using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstCursus
{
    class VDABContext : DbContext
    {
        public DbSet<Instructeur> Instructeurs { get; set; }
        public DbSet<Campus> Campussen { get; set; }
        public DbSet<Land> Landen { get; set; }
        public DbSet<Cursus> Cursussen { get; set; }
        public DbSet<Verantwoordelijkheid> Verantwoordelijkheden { get; set; }
        public DbSet<Cursist> Cursisten { get; set; }

        // nodig voor TPH
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<KlassikaleCursus>().Map(m => m.Requires("Soort").HasValue("K"));
        //    modelBuilder.Entity<ZelfstudieCursus>().Map(m => m.Requires("Soort").HasValue("Z"));
        //}

        // nodig voor TPC
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KlassikaleCursus>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<ZelfstudieCursus>().Map(m => m.MapInheritedProperties());

            modelBuilder.Entity<Instructeur>()
                .HasMany(i=>i.Verantwoordelijkheden)
                .WithMany(v=>v.Instructeurs)
                .Map(c => c.ToTable("InstructeursVerantwoordelijkheden")
                    .MapLeftKey("VerantwoordelijkheidID")
                    .MapRightKey("InstructeurNr"));
        }
    }
}