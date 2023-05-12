using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entiteter.InterfaceKlasser
{
    public interface ISkor
    {
        int Storlek { get; set; }
        string Skotyp { get; set; }
        string Modell { get; set; }
    }
}
