using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    class CountriesTextFile
    {
        public static string CheckCountriesTextFile()
        {
            /********Is there a way to automatically create the file in the folder that this exists in instead of an exact path?****/
            var directoryPath = @"C:\Users\krist\source\repos\Lab16\Lab16\CountriesFile.txt"; 
            if (File.Exists(directoryPath) == false)
            {
                new StreamWriter(directoryPath);
            }
            SortByAlphabeticalOrder(directoryPath);
            return directoryPath;
        }

        public static void ReadCountries(string file)
        {
            using (var reader = new StreamReader(file))
            {
                string line;
                do
                {
                    line = reader.ReadLine();
                    Console.WriteLine(line);
                } while (line != null);
            }
        }

        public static void WriteCountries(string file, string countryToWrite)
        {
            using (var writer = new StreamWriter(file, true))
            {
                writer.WriteLine(countryToWrite);            
            }
            SortByAlphabeticalOrder(file);
        }

        public static void DeleteCountry(string file, string countryToDelete)
        {
            var listOfCountries = File.ReadAllLines(file);
            var newListOfCountries = listOfCountries.Where(line => !line.Contains(countryToDelete));
            File.WriteAllLines(file, newListOfCountries);
        }

        private static void SortByAlphabeticalOrder(string file)
        {
            var listOfCountries = File.ReadAllLines(file);
            var newListOfCountries = listOfCountries.OrderBy(x => x).ToList();
            File.WriteAllLines(file, newListOfCountries);
        }
    }
}
