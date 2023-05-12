using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Datalager;
using Datalager.IRepository;
using Entiteter.Klasser;
using Microsoft.Data.SqlClient;

namespace Affärslager
{

    public class Kontroller
    {
        public Kontroller() { }

        public UnitOfWork unitOfWork
        {
            get => default;
            set
            {
            }
        }
        public Datalager.Repository.Repository<object> Repository
        {
            get => default;
            set
            {
            }
        }
        //public void Kör()
        //{

        //    KlädKontext DbContext = new KlädKontext();
        //    DbContext.Database.EnsureDeleted();
        //    DbContext.Database.EnsureCreated();
        //}
        public void LaddaData()
        {
            KlädKontext DbContext = new KlädKontext();
            DbContext.Reset();
            DbContext.Database.EnsureCreated();
        }
        public IList<Klädesplagg> Getklädesplagg(long pNR)
        {
            //return unitofwork.PersonRepository.Find(k => k.Garderob)


            List<Klädesplagg> Garderob = new List<Klädesplagg>();
            Person person = unitOfWork.Person.FirstOrDefault(p => p.PersonNummerID == pNR);
            foreach (Klädesplagg k in person.Garderob)
            {
                Garderob.Add(k);
            }

            return Garderob;

        }
        public List<Person> GetAllPersons()
        {
            using (var connection = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=Cipers;Trusted_Connection=True;"))
            {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM Persons", connection);
                var reader = command.ExecuteReader();

                var persons = new List<Person>();

                while (reader.Read())
                {
                    var person = new Person();
                    person.PersonNummerID = (long)reader["PersonnummerID"];
                    person.FörNamn = reader["Namn"].ToString();
                    person.Plats = reader["Adress"].ToString();
                    // Add any additional properties here

                    persons.Add(person);
                }

                return persons;
            }

        }
        //public Person HittaPerson(long id)
        //{
        //    return unitOfWork.Person.FirstOrDefault(p => p.PersonNummerID == id);
        //}
        public IList<Person> HittaPerson()
        {
            using (UnitOfWork unit = new UnitOfWork())
            {
                return unit.Person.GetAll().ToList();
            }
        }
        public IList<Klädesplagg> HittaKläder()
        {
            using (UnitOfWork unit = new UnitOfWork())
            {
                return unit.Klädesplagg.GetAll().ToList();
            }
        }
        //public IList<Bok> HämtaBokningensBöcker(int EttNr)
        //{
        //    List<Bok> bikbok = new List<Bok>();
        //    using (UnitOfWork unit = new UnitOfWork())
        //    {
        //        Bokning bokning2 = unit.Bokning.FirstOrDefault(b => b.BokningId == EttNr || b.Tillhör == EttNr);

        //        foreach (Bok b in bokning2.BokadeBöcker)
        //        {
        //            bikbok.Add(b);
        //        }
        //        return bikbok;
        //    }
        //}
    }

        
}
