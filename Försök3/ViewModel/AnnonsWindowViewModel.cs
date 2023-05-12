using Affärslager;
using Entiteter;
using Entiteter.Enums;
using Försök3.Commands;
using Försök3.Models;
using Försök3.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Försök3.Services;
using static Azure.Core.HttpHeader;
using System.Windows.Controls;
using Entiteter.Klasser;
using Entiteter.InterfaceKlasser;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Windows;

namespace Försök3.ViewModel
{
    class AnnonsWindowViewModel : ObservableObject
    {
        private Kontroller kontroller = new Kontroller();

        WindowService windowService = new WindowService();
        //private ObservableCollection<Bok> biblioteketsböcker = null!;
        //public ObservableCollection<Bok> BiblioteketsBöcker { get => biblioteketsböcker; set { biblioteketsböcker = value; OnPropertyChanged(); } }


        public ObservableCollection<Klädesplagg> klädesplagg;
        public ObservableCollection<Person> person;

        public Person GetData()
        {
            Person minPerson = new Person();
            foreach (Person item in person)
            {
                minPerson = item;
            }
            return minPerson;
        }
        

        private Person minPerson = null!;
        public Person MinPerson { get => minPerson; set { minPerson = value; OnPropertyChanged(); } }


        public AnnonsWindowViewModel()
        {
            windowService = new WindowService();
        }
        public AnnonsWindowViewModel(ObservableCollection<Person> tempPerson, ObservableCollection<Klädesplagg> tempklädesplag)
        {           
            windowService = new WindowService();
            person = tempPerson;
            klädesplagg = tempklädesplag;
            GetData();
        }

        //public int AnnonsId
        


        //----------------------------------------//
        private string[] kategori = { "För Hemmet", "Personligt", "Elektronik", "Fritid & Hobby", "Övrigt" };
        public string[] Kategori { get => kategori; set { kategori = value; OnPropertyChanged(); } }

        //----------------------------------------//
        private string[] underkategori = { "Kläder & Skor", "Accessoarer & Klockor", "Barnkläder & Skor", "Barnarticklar & leksaker" };
        public string[] Underkategori { get => underkategori; set { underkategori = value; OnPropertyChanged(); } }

        //----------------------------------------//
        private string beskrivning = null!;
        public string Beskrivning { get => beskrivning; set { beskrivning = value; OnPropertyChanged(); } }

        //----------------------------------------//
        private string annonsPris = null!;
        public string AnnonsPris { get => annonsPris; set { annonsPris = value; OnPropertyChanged(); } }

        //----------------------------------------//
        //public bool Postas
        // Vill du posta?

        //----------------------------------------//
        //public Skick Skick
        // Vad är den för skick

        //----------------------------------------//
        private Klädesplagg storlek = null!;
        public Klädesplagg Storlek { get => storlek; set { storlek = value; OnPropertyChanged(); } }

        //----------------------------------------//
        private Klädesplagg rubrik = null!;
        public Klädesplagg Rubrik { get => rubrik; set { rubrik = value; OnPropertyChanged(); } }

        //----------------------------------------//
        private Klädesplagg skapadAv = null!;
        public Klädesplagg SkapadAv { get => skapadAv; set { skapadAv = value; OnPropertyChanged(); } }

        //----------------------------------------//
        private Klädesplagg plats = null!;
        public Klädesplagg Plats { get => plats; set { plats = value; OnPropertyChanged(); } }

        //----------------------------------------//
        private Klädesplagg kommun = null!;
        public Klädesplagg Kommun { get => kommun; set { kommun = value; OnPropertyChanged(); } }

        //----------------------------------------//
        private Klädesplagg postNummer = null!;
        public Klädesplagg PostNummer { get => postNummer; set { postNummer = value; OnPropertyChanged(); } }

        //--------------IMAGE----------------------//

        private string displayImage = null!;
        public string DisplayImage { get => displayImage; set { displayImage = value; OnPropertyChanged(); } }


        Klädesplagg kläder = null!;
        public Klädesplagg Kläder { get => kläder; set { kläder = value; OnPropertyChanged(); } }


        ICommand skapaAnnonsCommand = null!;
        public ICommand SkapaAnnonsCommand => skapaAnnonsCommand ??= skapaAnnonsCommand = new RelayCommand(() =>
        {
            MessageBox.Show("Annons Publicerad");
        });

    }
}
