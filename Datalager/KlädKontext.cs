using Entiteter;
using Entiteter.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Datalager
{
    public class KlädKontext : DbContext //this is the database session/connection
    {
        //database tables to create
        public DbSet<Annons> Annons { get; set; }
        public DbSet<Byxor> Byxor { get; set; }
        public DbSet<Jeans> Jeans { get; set; }
        public DbSet<Skor> Skor { get; set; }
        public DbSet<Tröja> Tröja { get; set; }

        public KlädKontext()
        {
            //INSTRUCTION: Run program once and make a login (might "freeze" ~10 sec, just wait), close down, then comment resetSeed()-line below away. Then the database will be presistent onwards 

            resetSeed(); //uncomment to (re)create database & fill/seed example data
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true) //appsettings.json typically used for entityframeworkcore
                    .Build()                                     //don't forget set "copy if newer" on appsettings.json to be included in build 
                    .GetConnectionString("SecondHandKläder"));

            //this "hardcoded" version can be used aswell, but better parctice to put connectionstring in a setting/config-file
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarPool;Trusted_Connection=True;");

            base.OnConfiguring(optionsBuilder);
        }

        private void resetSeed()
        {
            #region Byxor
            Byxor.Add(new Byxor("M", "Slim", 1001, "Blå", 499.50f, new DateTime(2022, 4, 1), "Levi's", "510 Skinny Fit", true, Kön.Man));
            Byxor.Add(new Byxor("S", "Loose", 1002, "Grön", 349.00f, new DateTime(2022, 2, 14), "H&M", "Loose Fit", false, Kön.Kvinna));
            Byxor.Add(new Byxor("L", "Regular", 1003, "Svart", 599.00f, new DateTime(2022, 5, 21), "G-Star RAW", "3301 Straight", true, Kön.Man));
            Byxor.Add(new Byxor("XL", "Tapered", 1004, "Röd", 799.00f, new DateTime(2022, 3, 7), "Calvin Klein", "Slim Tapered", false, Kön.Man));
            Byxor.Add(new Byxor("XS", "Skinny", 1005, "Vit", 449.50f, new DateTime(2022, 1, 30), "Zara", "Skinny Fit", true, Kön.Kvinna));
            Byxor.Add(new Byxor("M", "Relaxed", 1006, "Gul", 299.00f, new DateTime(2022, 6, 18), "Uniqlo", "Relaxed Fit", false, Kön.Kvinna));
            Byxor.Add(new Byxor("S", "Straight", 1007, "Brun", 699.00f, new DateTime(2022, 3, 15), "Diesel", "Larkee", true, Kön.Man));
            Byxor.Add(new Byxor("L", "Bootcut", 1008, "Rosa", 899.00f, new DateTime(2022, 2, 2), "Tommy Hilfiger", "Bootcut Fit", false, Kön.Kvinna));
            Byxor.Add(new Byxor("XL", "Flare", 1009, "Grå", 549.50f, new DateTime(2022, 4, 28), "Mango", "Flared", true, Kön.Kvinna));
            Byxor.Add(new Byxor("M", "Cropped", 1010, "Beige", 399.00f, new DateTime(2022, 1, 15), "Weekday", "Row Cropped", false, Kön.Kvinna));
            #endregion
            #region Jeans
            Jeans.Add(new Jeans("Slim", 32, 30, 1001, "Blå", 499.99f, DateTime.Now, "Levi's", "510 Skinny Fit Jeans", true, Kön.Man));
            Jeans.Add(new Jeans("Straight", 34, 32, 1002, "Svart", 599.99f, DateTime.Now, "Lee", "Daren Regular Straight Jeans", true, Kön.Man));
            Jeans.Add(new Jeans("Skinny", 30, 28, 1003, "Mörkblå", 449.99f, DateTime.Now, "H&M", "Super Skinny High Jeans", true, Kön.Kvinna));
            Jeans.Add(new Jeans("Tapered", 36, 34, 1004, "Grå", 679.99f, DateTime.Now, "G-Star RAW", "5620 3D Tapered Jeans", true, Kön.Man));
            Jeans.Add(new Jeans("Bootcut", 32, 30, 1005, "Ljusblå", 399.99f, DateTime.Now, "Wrangler", "Texas Bootcut Jeans", true, Kön.Man));
            Jeans.Add(new Jeans("Boyfriend", 28, 26, 1006, "Vit", 299.99f, DateTime.Now, "Zara", "Boyfriend Jeans", true, Kön.Kvinna));
            Jeans.Add(new Jeans("Flare", 30, 28, 1007, "Blå", 599.99f, DateTime.Now, "Diesel", "Slandy Flare Jeans", true, Kön.Kvinna));
            Jeans.Add(new Jeans("Loose", 34, 32, 1008, "Mörkgrön", 449.99f, DateTime.Now, "Jack & Jones", "Mike Original Jeans", true, Kön.Man));
            Jeans.Add(new Jeans("Relaxed", 36, 34, 1009, "Kaki", 519.99f, DateTime.Now, "Calvin Klein", "Relaxed Fit Jeans", true, Kön.Man));
            Jeans.Add(new Jeans("Slim", 28, 26, 1010, "Röd", 359.99f, DateTime.Now, "Mango", "Slim-Fit Push-Up Jeans", true, Kön.Kvinna));
            #endregion
            #region Tröja

            Tröja.Add(new Tröja("M", "Normal", 1001, "Blå", 199.99f, new DateTime(2022, 4, 15), "H&M", "Bomullströja", true, Kön.Man));
            Tröja.Add(new Tröja("M", "Normal", 1002, "Grön", 249.99f, new DateTime(2022, 4, 16), "Zara", "Stickad tröja", true, Kön.Man));
            Tröja.Add(new Tröja("L", "Lös", 1003, "Svart", 299.99f, new DateTime(2022, 4, 17), "Levi's", "Hoodie", true, Kön.Man));
            Tröja.Add(new Tröja("M", "Normal", 1004, "Vit", 149.99f, new DateTime(2022, 4, 18), "Nike", "T-shirt", true, Kön.Man));

            Tröja.Add(new Tröja("S", "Normal", 2001, "Röd", 199.99f, new DateTime(2022, 4, 19), "H&M", "Bomullströja", true, Kön.Kvinna));
            Tröja.Add(new Tröja("M", "Lös", 2002, "Gul", 249.99f, new DateTime(2022, 4, 20), "Zara", "Stickad tröja", true, Kön.Kvinna));
            Tröja.Add(new Tröja("L", "Normal", 2003, "Blå", 299.99f, new DateTime(2022, 4, 21), "Levi's", "Hoodie", true, Kön.Kvinna));
            Tröja.Add(new Tröja("M", "Normal", 2004, "Svart", 149.99f, new DateTime(2022, 4, 22), "Nike", "T-shirt", true, Kön.Kvinna));

            Tröja.Add(new Tröja("M", "Normal", 3001, "Grå", 199.99f, new DateTime(2022, 4, 23), "H&M", "Bomullströja", true, Kön.Unisex));
            Tröja.Add(new Tröja("L", "Normal", 3002, "Röd", 249.99f, new DateTime(2022, 4, 24), "Zara", "Stickad tröja", true, Kön.Unisex));
            #endregion
            #region Skor
            Skor.Add(new Skor(42, "löparskor", "Air Max", 1001, "vit", 899.50f, new DateTime(2022, 4, 15), "Nike", "Air Max", true, Kön.Man));
            Skor.Add(new Skor(43, "promenadskor", "Free Run", 1002, "grå", 799.00f, new DateTime(2022, 5, 2), "Adidas", "Free Run", true, Kön.Man));
            Skor.Add(new Skor(44, "sneakers", "Chuck Taylor", 1003, "svart", 599.99f, new DateTime(2022, 3, 20), "Converse", "Chuck Taylor", true, Kön.Man));

            Skor.Add(new Skor(38, "löparskor", "Gel-Nimbus", 2001, "rosa", 1299.50f, new DateTime(2022, 2, 10), "Asics", "Gel-Nimbus", true, Kön.Kvinna));
            Skor.Add(new Skor(39, "promenadskor", "Go Walk", 2002, "vit", 699.00f, new DateTime(2022, 3, 1), "Skechers", "Go Walk", true, Kön.Kvinna));
            Skor.Add(new Skor(40, "sneakers", "Blazer Mid Vintage", 2003, "grön", 899.99f, new DateTime(2022, 4, 5), "Nike", "Blazer Mid Vintage", true, Kön.Kvinna));

            Skor.Add(new Skor(41, "löparskor", "Glycerin", 3001, "blå", 1499.50f, new DateTime(2022, 1, 15), "Brooks", "Glycerin", true, Kön.Unisex));
            Skor.Add(new Skor(42, "promenadskor", "Joyride Run Flyknit", 3002, "grå", 1099.00f, new DateTime(2022, 2, 28), "Nike", "Joyride Run Flyknit", true, Kön.Unisex));
            Skor.Add(new Skor(43, "sneakers", "Superstar", 3003, "svart", 799.99f, new DateTime(2022, 5, 1), "Adidas", "Superstar", true, Kön.Unisex));

            #endregion


            SaveChanges();
        }
    }
}