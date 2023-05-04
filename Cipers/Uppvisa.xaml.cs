using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cipers
{

    public partial class Uppvisa : Window
    {
        public Uppvisa()
        {
            InitializeComponent();

            List<Byxor> byxGarderob = new List<Byxor>()
            {
                new Byxor("Cargothraks", "FigoBoss", "Sandbrun", 36, 30, "Bomull"),
                new Byxor("Cascade Jeans", "Frada", "Grå", 32, 34, "Bomull"),
                new Byxor("Camo Cargos", "Segway", "Grön", 34, 32, "Bomull"),
                new Byxor("yStar Runners", "Ystar", "Svart", 38, 34, "Bomull"),
                new Byxor("Parachute Popelin", "Hike", "Rosa", 30, 32, "Bomull"),
                new Byxor("Seamless Leggin", "Liis", "Mörkblå", 32, 30, "Bomull"),
                new Byxor("Lis Wides", "Elvis", "Fuschia", 40, 34, "Bomull"),
            };
            gridden.ItemsSource = byxGarderob;
            
        }



    }
}
