using System;
using System.Collections.Generic;
using Phoneshop.ConsoleApp._1._Phoneshop.Business;

namespace Phoneshop.ConsoleApp
{
    internal class Program
    {   

        static public List<Phone> _phones = new();


        static void Main()
        {
            bool showMenu = true;

            while (showMenu)
            {
                showMenu = MainMenu();
                Console.ReadLine();
            }

        }

        private static bool MainMenu()
        {
            //zorgen voor iets wat verkeerde input opvangt
            Console.Clear();
            Console.WriteLine("Please choose the desired phone by pressing the corresponding number\n");
                foreach(_phone in Phone)
                {
                Console.WriteLine($"{_phones[0].Id} {_phones[0].Brand} {_phones[0].PType}");
                }
                
            
            var userInput = Console.ReadKey();
            int phones;

            if (char.IsDigit(userInput.KeyChar))
                {
                phones = int.Parse(userInput.KeyChar.ToString());
                Console.Clear();
                Console.WriteLine($"{_phones[0].Brand} {_phones[0].PType} €{_phones[0].PriceVAT} \n{_phones[0].Description}");
                Console.WriteLine("Press any to go back to the main menu\n");
                Console.ReadKey();
                return MainMenu();
                }

            else
            {
                phones = -1;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("User did not input a number");
                Console.ReadKey();
                return MainMenu();
            }

        }
    }
}
