using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    class Validator
    {
        public static int UserChoice()
        {
            int userChoice = 0;
            bool validChoice = false;

            while (validChoice == false || userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("1 - See list of countries");
                Console.WriteLine("2 - Add a country");
                Console.WriteLine("3 - Delete a country");
                Console.WriteLine("4 - Exit");
                Console.Write("\nEnter menu number: ");
                validChoice = int.TryParse(Console.ReadLine(), out userChoice);
                if (validChoice == true)
                {
                    break;
                }
                Console.WriteLine("Sorry, that wasn't a valid choice, please try again!");
            } 
            return userChoice;
        }

        public static string CountryChoice()
        {
            bool validCountry = false;
            string country = "";

            while (validCountry == false)
            {
                country = Console.ReadLine();
                int lengthOfCountry = country.Length;

                if (country.Any(char.IsDigit))
                {
                    Console.WriteLine("Sorry, it looks like you have numbers in the country name. Try it again.");
                }
                else if (lengthOfCountry < 4 || lengthOfCountry > 74)
                {
                    Console.WriteLine("Sorry, that doesn't seem to be a country.  Try the name unabreviated.");
                }
                else
                {
                    validCountry = true;
                }
            }
            return country;
        }

        public static string CountryInList(string file)
        {
            string country = "";

            bool CountryInList = false;
            while (CountryInList == false)
            {
                Console.Write("Enter country: ");
                country = CountryChoice();
                using (var reader = new StreamReader(file))
                {
                    string line;
                    do
                    {
                        line = reader.ReadLine();
                        if (country == line)
                        {
                            CountryInList = true;
                            break;
                        }
                    } while (line != null && CountryInList == false);

                    if (CountryInList == false)
                    {
                    Console.WriteLine("Sorry, that country isn't in the list!");
                    }
                }
            }
            return country;
        }
    }
}
