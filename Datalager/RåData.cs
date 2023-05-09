using Microsoft.EntityFrameworkCore;
using Entiteter;
using System;

namespace Datalager
{
    public static class RåData
    {
        public static void Populate(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jeans>().HasData(
                new Jeans() { Passform = "Slim", Längdmått = 32, Midjemått = 30, PlaggID = 1001, Färg = "Blå", Nypris = 499.99f, Inköpsdatum = DateTime.Now, Varumärke = "Levi's", ProduktNamn = "510 Skinny Fit Jeans", Annonserad = true, Kön = 0 }

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
