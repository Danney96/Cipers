using Microsoft.EntityFrameworkCore;
using Entiteter;
using System;
using Entiteter.Enums;

namespace Datalager
{
    public static class RåData
    {
        public static void Populate(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jeans>().HasData(
                new Jeans() { Passform = "Slim", Längdmått = 32, Midjemått = 30, PlaggID = 1001, Färg = "Blå", Nypris = 499.99f, Inköpsdatum = DateTime.Now, Varumärke = "Levi's", ProduktNamn = "510 Skinny Fit Jeans", Annonserad = true, Kön = 0 }

                );

            modelBuilder.Entity<Person>().HasData(
                new Person() { PersonNummerID = 202305113188, FörNamn ="Erik", EfterNamn ="Felin", Alias = "SnyggaJeansBilligt", Kommun ="Borås", Plats ="Älsborg", PostNummer=50190}

                );
            
             modelBuilder.Entity<Tröja>().HasData(
                new Tröja() { Storlek = "M", Passform= "Normal", PlaggID= 1002, Färg= "Blå",Nypris= 199.99f, Inköpsdatum= new DateTime(2022, 4, 15), Varumärke= "H&M", ProduktNamn="Bomullströja", Annonserad= true, Kön= Kön.Man }

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
