using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    class CountriesApp
    {
        public static void Greeting()
        {
            Console.WriteLine("Welcome to the Countries Maintenance Application!");
        }

        public static int GetUserChoice()
        {
            int choice = Validator.UserChoice();
            return choice;
        }
        
        
    }
}
