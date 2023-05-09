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

        private ObservableCollection<Byxor> xByxor = null!;
        public ObservableCollection<Byxor> XByxor { get => xByxor; set { xByxor = value; OnPropertyChanged(); } }

        public MainViewModel()
        {
            kontroller = new Kontroller();
            kontroller.Kör();

            XByxor = new ObservableCollection<Byxor>();
        }
    }
}
