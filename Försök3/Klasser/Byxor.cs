using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Försök3.Klasser
{
    public class Byxor
    {


        public string Namn { get; set; }
        public string Märke { get; set; }
        public string Färg { get; set; }
        public int Midja { get; set; }
        public int Längd { get; set; }
        public string Material { get; set; }
        public Byxor(string namn, string märke, string färg, int midja, int längd, string material)
        {
            Namn = namn;
            Märke = märke;
            Färg = färg;
            Midja = midja;
            Längd = längd;
            Material = material;
        }
    }
}
