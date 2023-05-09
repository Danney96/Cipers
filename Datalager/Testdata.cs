using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entiteter;
using Entiteter.Enums;

namespace Datalager
{
    internal class Testdata
    {


    }
    public void ExempelData()
    {
        Byxor byxa1 = new Byxor("M", "Slim", 1001, "Blå", 499.50f, new DateTime(2022, 4, 1), "Levi's", "510 Skinny Fit", true, Kön.Man);
        Byxor byxa2 = new Byxor("S", "Loose", 1002, "Grön", 349.00f, new DateTime(2022, 2, 14), "H&M", "Loose Fit", false, Kön.Kvinna);
        Byxor byxa3 = new Byxor("L", "Regular", 1003, "Svart", 599.00f, new DateTime(2022, 5, 21), "G-Star RAW", "3301 Straight", true, Kön.Man);
        Byxor byxa4 = new Byxor("XL", "Tapered", 1004, "Röd", 799.00f, new DateTime(2022, 3, 7), "Calvin Klein", "Slim Tapered", false, Kön.Man);
        Byxor byxa5 = new Byxor("XS", "Skinny", 1005, "Vit", 449.50f, new DateTime(2022, 1, 30), "Zara", "Skinny Fit", true, Kön.Kvinna);
        Byxor byxa6 = new Byxor("M", "Relaxed", 1006, "Gul", 299.00f, new DateTime(2022, 6, 18), "Uniqlo", "Relaxed Fit", false, Kön.Kvinna);
        Byxor byxa7 = new Byxor("S", "Straight", 1007, "Brun", 699.00f, new DateTime(2022, 3, 15), "Diesel", "Larkee", true, Kön.Man);
        Byxor byxa8 = new Byxor("L", "Bootcut", 1008, "Rosa", 899.00f, new DateTime(2022, 2, 2), "Tommy Hilfiger", "Bootcut Fit", false, Kön.Kvinna);
        Byxor byxa9 = new Byxor("XL", "Flare", 1009, "Grå", 549.50f, new DateTime(2022, 4, 28), "Mango", "Flared", true, Kön.Kvinna);
        Byxor byxa10 = new Byxor("M", "Cropped", 1010, "Beige", 399.00f, new DateTime(2022, 1, 15), "Weekday", "Row Cropped", false, Kön.Kvinna);
    }

}
