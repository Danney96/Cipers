using Försök3.Commands;
using Försök3.Models;
using Affärslager;
using Entiteter;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Datalager;

namespace Försök3.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private Kontroller kontroller;

        public MainViewModel()
        {
            kontroller = new Kontroller();
            kontroller.Kör();
            //kontroller = new Kontroller();
            //kontroller.LaddaData();

            //RefreshCommand.Execute(null);
        }
        private ObservableCollection<Klädesplagg> klädesplagg = null!;
        public ObservableCollection<Klädesplagg> Klädesplaggs { get => klädesplagg; set { klädesplagg = value; OnPropertyChanged(); } }

        private ObservableCollection<Klädesplagg> person = null!;
        public ObservableCollection<Klädesplagg> Persons { get => person; set { person = value; OnPropertyChanged(); } }

    }
}
