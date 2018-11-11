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
            var directoryPath = @"C:\Users\krist\source\repos\Lab16\Lab16\CountriesFile.txt";
            if (File.Exists(directoryPath) == false)
            {
                new StreamWriter(directoryPath);
            }
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
        }

        public static void DeleteCountry(string file, string countryToDelete)
        {
            var listOfCountries = System.IO.File.ReadAllLines(file);
            var newListOfCountries = listOfCountries.Where(line => !line.Contains(countryToDelete));
            System.IO.File.WriteAllLines(file, newListOfCountries);
        }
    }
}
