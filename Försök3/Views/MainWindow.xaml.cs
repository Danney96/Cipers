using Affärslager;
using Entiteter;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Försök3.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    // Välj en person från ComboBoxen
        //    var selectedPerson = (Person)comboPerson.SelectedItem;

        //    // Välj en klädesplagg från ComboBoxen
        //    var selectedKlädesplagg = (Klädesplagg)comboPlagg.SelectedItem;

        //    // Skapa en ny annons med personens personnummer som skapad av attributet
        //    var newAnnons = new Annons
        //    {
        //        SkapadAv = selectedPerson.PersonNummerID,
        //        Kategori = "Kläder",
        //        Underkategori = selectedKlädesplagg.Typ,
        //        Beskrivning = $"Säljer {selectedKlädesplagg.Produktnamn}",
        //        AnnonsDatum = DateTime.Now,
        //        Rubrik = $"Säljer {selectedKlädesplagg.Produktnamn}",
        //        Annonspris = selectedKlädesplagg.Nypris / 2,
        //        Skick = "Bra"
        //    };

        //    // Använd Selenium och Chrome för att logga in på Blocket.se och skapa en ny annons
        //    var chromeOptions = new ChromeOptions();
        //    chromeOptions.AddArguments("--disable-extensions");
        //    chromeOptions.AddArguments("--headless");
        //    chromeOptions.AddArguments("--disable-gpu");
        //    chromeOptions.AddArguments("--no-sandbox");
        //    var driver = new ChromeDriver(chromeOptions);

        //    driver.Navigate().GoToUrl("https://www.blocket.se/login");

        //    var usernameField = driver.FindElement(By.Name("username"));
        //    usernameField.SendKeys("s2105691@student.hb.se");

        //    var passwordField = driver.FindElement(By.Name("password"));
        //    passwordField.SendKeys("FredrikFredrik1337");

        //    var loginButton = driver.FindElement(By.XPath("//button[@type='submit']"));
        //    loginButton.Click();

        //    driver.Navigate().GoToUrl("https://www.blocket.se/ladda_upp_annons");

        //    var kategoriSelect = new SelectElement(driver.FindElement(By.Id("category-id")));
        //    kategoriSelect.SelectByText("Kläder och skor");

        //    var underkategoriSelect = new SelectElement(driver.FindElement(By.Id("subcategory-id")));
        //    underkategoriSelect.SelectByText(selectedKlädesplagg.Typ);

        //    var beskrivningField = driver.FindElement(By.Id("add-description"));
        //    beskrivningField.SendKeys(newAnnons.Beskrivning);

        //    var prisField = driver.FindElement(By.Id("add-price"));
        //    prisField.SendKeys(newAnnons.Annonspris.ToString());

        //    var skickSelect = new SelectElement(driver.FindElement(By.Id("condition")));
        //    skickSelect.SelectByText(newAnnons.Skick);

        //    var rubrikField = driver.FindElement(By.Id("add-headline"));
        //    rubrikField.SendKeys(newAnnons.Rubrik);

        //    var publiceraAnnonsButton = driver.FindElement(By.Id("post-submit"));
        //    publiceraAnnonsButton.Click();

        //    driver.Quit();
        //}
    }
}
