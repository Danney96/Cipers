using Försök3.Commands;
using Försök3.Models;
using Affärslager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Datalager;
using Microsoft.Data.SqlClient;
using Entiteter.Klasser;
using Försök3.Services;

namespace Försök3.ViewModel
{
    //public class MainViewModel : ObservableObject
    //{
    //    private Kontroller kontroller;

    //    public MainViewModel()
    //    {
    //        kontroller = new Kontroller();
    //        //kontroller.Kör();
    //        kontroller.LaddaData();
    //    }
    //    private ObservableCollection<Klädesplagg> klädesplagg = null!;
    //    public ObservableCollection<Klädesplagg> Klädesplaggs { get => klädesplagg; set { klädesplagg = value; OnPropertyChanged(); } }

    //    private ObservableCollection<Person> person = null!;
    //    public ObservableCollection<Person> Persons { get => person; set { person = value; OnPropertyChanged(); } }

    //    private int personSelectedIndex;
    //    public int PersonSelectedIndex
    //    {
    //        get { return personSelectedIndex; }
    //        set
    //        {
    //            personSelectedIndex = value; OnPropertyChanged();
    //        }
    //    }

    //    private Person personSelectedItem = null!;
    //    public Person PersonSelectedItem
    //    {
    //        get { return personSelectedItem; }
    //        set
    //        {
    //            personSelectedItem = value; OnPropertyChanged();
    //            long id = 202305112232;
    //            Persons = new ObservableCollection<Person>(kontroller.HittaPerson(id));

    //        }
    //    }

    //}
    public class MainViewModel : ObservableObject
    {
        WindowService windowService = new WindowService();
        private Kontroller kontroller;
        //private ObservableCollection<Klädesplagg> klädesplagg;
        //private ObservableCollection<Person> person;

       
        
        private ObservableCollection<Person> person = null!;
        public ObservableCollection<Person> Person { get => person; set { person = value; OnPropertyChanged(); } }

        // -------------------------------------------------------- //
        private ObservableCollection<Klädesplagg> klädesplagg = null!;
        
        public ObservableCollection<Klädesplagg> Klädesplaggs { get => klädesplagg; set { klädesplagg = value; OnPropertyChanged(); } }



        private Annons nyAnnons = null!;
        public Annons NyAnnons { get => nyAnnons; set { nyAnnons = value; OnPropertyChanged(); } }

        // -------------------------------------------------------- //

        private ObservableCollection<Klädesplagg> valtPlagg = null!;
        public ObservableCollection<Klädesplagg> ValtPlagg { get => valtPlagg; set { valtPlagg = value; OnPropertyChanged(); } }

        private bool isNotModified = true;
        public bool IsNotModified { get { return isNotModified; } set { isNotModified = value; OnPropertyChanged(); } }
        public MainViewModel()
        {
            kontroller = new Kontroller();
            //kontroller.Kör();
            kontroller.LaddaData();
            RefreshCommand.Execute(null);
        }


        public ObservableCollection<Person> Persons
        {
            get => person;
            set
            {
                person = value;
                OnPropertyChanged();
            }
        }

        private Person personSelectedItem = null!;
        public Person PersonSelectedItem
        {
            get { return personSelectedItem; }
            set
            {
                
                personSelectedItem = value;
                OnPropertyChanged();
                
            }
        }
        private int klädesplaggSelectedIndex;
        public int KlädesplaggSelectedIndex
        {
            get => klädesplaggSelectedIndex;
            set
            {
                klädesplaggSelectedIndex = value;
                OnPropertyChanged();
            }
        }

        //private Klädesplagg klädesplaggSelectedItem;
        //public Klädesplagg KlädesplaggSelectedItem
        //{
        //    get => klädesplaggSelectedItem;
        //    set
        //    {
        //        long id = 202305112232;
        //        klädesplaggSelectedItem = value;
        //        OnPropertyChanged();
        //        if (value != null)
        //        {
        //            Klädesplaggs = new ObservableCollection<Klädesplagg>(kontroller.HittaKläder());
        //        }
        //    }
        //}
        private Klädesplagg klädesplaggSelectedItem = null!;
        public Klädesplagg KlädesplaggSelectedItem
        {
            get { return klädesplaggSelectedItem; }
            set
            {
                klädesplaggSelectedItem = value; OnPropertyChanged();
            }
        }

        private int personSelectedIndex;
        public int PersonSelectedIndex
        {
            get => personSelectedIndex;
            set
            {
                personSelectedIndex = value;
                OnPropertyChanged();
            }
        }

        private ICommand skapaAnnonsCommand = null!;
        public ICommand SkapaAnnonsCommand => skapaAnnonsCommand ??= skapaAnnonsCommand = new RelayCommand(() =>
        {
            NyAnnons = kontroller.SkapaAnnons(personSelectedItem, KlädesplaggSelectedItem);
            if (NyAnnons != null)
            {
                
                AnnonsWindowViewModel vy = new AnnonsWindowViewModel(NyAnnons);

                bool result = windowService.ShowDialog(vy);

            }

        });


        private ICommand refreshCommand = null!;
        public ICommand RefreshCommand => refreshCommand ??= refreshCommand = new RelayCommand(() =>
        {


            Person = new ObservableCollection<Person>(kontroller.HittaPerson());
            
            Klädesplaggs = new ObservableCollection<Klädesplagg>(kontroller.HittaKläder());
            
            IsNotModified = true;
        });
    }
}
