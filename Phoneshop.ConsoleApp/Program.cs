using Phoneshop.ConsoleApp._1._Phoneshop.Business;
using System;

using System.Text;

namespace Phoneshop.ConsoleApp
{
    internal class Program
    {
        static readonly PhoneService phoneService = new();
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
            var _phones = phoneService._phones;
            //TODO zorgen voor iets wat verkeerde input opvangt
            Console.Clear();

            Console.WriteLine("Please choose the desired phone by pressing the corresponding number\n");
            foreach (Phone phone in _phones)
            {
                Console.WriteLine($"{phone.Id} {phone.Brand} \t{phone.PType}");
            }

            //Link to List in PhoneService, getphone?


            var userInput = Console.ReadKey(); //TODO kijken of did niet beter kan
            int phoneId;

            if (char.IsDigit(userInput.KeyChar))
            {
                phoneId = int.Parse(userInput.KeyChar.ToString());
                var chosenPhone = _phones.Find(x => x.Id == phoneId);
                if (chosenPhone != null)
                {
                    Console.Clear();
                    Console.WriteLine($"{chosenPhone.Brand} {chosenPhone.PType} €{chosenPhone.PriceVAT} without VAT €{chosenPhone.Price} \n{chosenPhone.Description}");
                    Console.WriteLine("Press any to go back to the main menu\n");
                    Console.ReadKey();
                    return MainMenu();
                }

                else
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("User did not chose one of the available numbers, press any to go back to the main menu\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    return MainMenu();

                }




            }

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("User did not input a number press any key to return to main menu.\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                return MainMenu();
            }


        }
    }
}

