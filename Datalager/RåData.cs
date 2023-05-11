using Microsoft.EntityFrameworkCore;
using Entiteter;
using Entiteter.Enums;
using System;

namespace Datalager
{
    public static class RåData
    {
        public static void Populate(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jeans>().HasData(
                new Jeans() { Passform = "Slim", Längdmått = 32, Midjemått = 30, PlaggID = 1001, Färg = "Blå", Nypris = 499.90f, Inköpsdatum = DateTime.Now, Varumärke = "Levi's", ProduktNamn = "510 Skinny Fit Jeans", Annonserad = true, Kön = 0 }

                );
            modelBuilder.Entity<Jeans>().HasData(
                new Jeans() { Passform = "Straight", Längdmått = 36, Midjemått = 32, PlaggID = 1002, Färg = "Svart", Nypris = 800, Inköpsdatum = DateTime.Now, Varumärke = "Lee's", ProduktNamn = "Rockstar Pitchdark", Annonserad = false, Kön = Kön.Kvinna}

                );
            modelBuilder.Entity<Person>().HasData(
                new Person() { PersonNummerID = 202305112232, FörNamn ="Erik", EfterNamn="Felin", Alias = "SnyggaJeansBilligt", Kommun = "Borås", Plats = "Älvsborg", PostNummer = 50190}

                );




            //modelBuilder.Entity<Byxor>().HasNoKey(


            //    );
            //modelBuilder.Entity<Tröja>().HasNoKey(


            //    );
            //modelBuilder.Entity<Skor>().HasNoKey(



            //    );
            //modelBuilder.Entity<Klädesplagg>().HasNoKey(


            //    );
            //modelBuilder.Entity<Person>().HasNoKey(


            //    );
            //modelBuilder.Entity<Annons>().HasNoKey(


            //    );


        }
    }
}
