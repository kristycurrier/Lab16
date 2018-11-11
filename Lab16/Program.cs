using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            var directoryPath = CountriesTextFile.CheckCountriesTextFile();

            CountriesApp.Greeting();
            bool keepGoing = true;
            while (keepGoing)
            {
                int choice = CountriesApp.GetUserChoice();

                if (choice == 1)
                {
                    CountriesTextFile.ReadCountries(directoryPath);
                }
                else if (choice == 2)
                {
                    string country = "";
                    Console.Write("Enter country: ");
                    country = Validator.CountryChoice();
                    Console.WriteLine("The country has been saved!");
                    CountriesTextFile.WriteCountries(directoryPath, country);
                }
                else if (choice == 3)
                {
                    string country = "";
                    Console.Write("Enter country: ");
                    country = Validator.CountryChoice();
                    CountriesTextFile.DeleteCountry(directoryPath, country);
                    Console.WriteLine("Country deleted!");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Goodbye!");
                    keepGoing = false;
                }
                else
                {
                    Console.WriteLine("That isn't a valid option, please enter a menu choice.");
                }
            }
            Console.ReadKey();
        }
    }
}
