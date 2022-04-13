using Phoneshop.ConsoleApp._1._Phoneshop.Business;
using System;
using System.Linq;
using System.Text;

namespace Phoneshop.ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            bool showMenu = true;

            while (showMenu)
            {
                showMenu = MainMenu();
                Console.ReadLine();
            }
        }

        public static bool MainMenu()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            //TODO catch incorrect input
            Console.Clear();
            var phoneService = new PhoneService();
            var _phones = phoneService._phones;
            Console.WriteLine("Please choose the desired phone by pressing the corresponding number\n");
            
            foreach (Phone phone in _phones)
            {
                Console.WriteLine($"{phone.Id} {phone.Brand} {phone.PType}");
            }
            
             //TODO Link to List in PhoneService, getphone? 

            var userInput = Console.ReadKey(); //TODO can i improve this?
            int phones;

            if (char.IsDigit(userInput.KeyChar))//TODO add VATless price
            {
                phones = int.Parse(userInput.KeyChar.ToString());
                Console.Clear();
                Console.WriteLine($"{_phones[0].Brand} {_phones[0].PType} €{_phones[0].PriceVAT} without VAT € - \n{_phones[0].Description}\n");
                Console.WriteLine("Press any to go back to the main menu\n");
                Console.ReadKey();
                return MainMenu();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("User did not input a number, press any key to go back to the main menu.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                return MainMenu();
            }
        }
    }
}
