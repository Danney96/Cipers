using Microsoft.EntityFrameworkCore;
using Entiteter.Enums;
using System;
using Entiteter.Klasser;

namespace Datalager
{
    public static class RåData
    {
        public static void Populate(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jeans>().HasData(
                new Jeans()
                {
                    Passform = "Slim",
                    Längdmått = 32,
                    Midjemått = 30,
                    PlaggID = 1001,
                    Färg = "Blå",
                    Nypris = 499.90f,
                    Inköpsdatum = DateTime.Now,
                    Varumärke = "adidas",
                    ProduktNamn = "adidas original",
                    Annonserad = true,
                    Kön = Kön.Kvinna
                }
            );

            modelBuilder.Entity<Jeans>().HasData(
                new Jeans()
                {
                    Passform = "Straight",
                    Längdmått = 36,
                    Midjemått = 32,
                    PlaggID = 1002,
                    Färg = "Svart",
                    Nypris = 800,
                    Inköpsdatum = DateTime.Now,
                    Varumärke = "Lee's",
                    ProduktNamn = "Rockstar Pitchdark",
                    Annonserad = false,
                    Kön = Kön.Man,
                    Tillhör = 202305112233
                }
            );

            modelBuilder.Entity<Person>().HasData(
                new Person()
                {
                    PersonNummerID = 202305112233,
                    FörNamn = "Erik",
                    EfterNamn = "Felin",
                    Alias = "SnyggaJeansBilligt",
                    Kommun = "Borås",
                    Plats = "Älvsborg",
                    PostNummer = 50190
                }
            );
        }
    }
}
