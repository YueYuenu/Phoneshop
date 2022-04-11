using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Phoneshop.ConsoleApp
{
    internal class Program
    {   
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;  // zorgt dat euroteken werkt
            bool showMenu = true;
            
            while (showMenu)
            {
                showMenu = MainMenu();
                Console.ReadLine();
            }
        }

        private static bool MainMenu()
        {
           
            Console.Clear();
            Console.WriteLine("Please choose the desired phone by pressing the corresponding number");
            foreach (Phone phone in _phones)
            {
                Console.WriteLine($"\n {_phones.Id[0]}{_phones[0].Brand}\t{_phones[0].pType}");
            }

            int phones = int.TryParse(Console.ReadKey());
            {
                
            }

            

            //add a foreach instead of the switch

            switch (phones) //inkorten, moet toch anders kunnen ;)  _phones.count? andere List functie?
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine($"{_phones[0].Brand} {_phones[0].pType} \u20AC{_phones[0].Price}\n{_phones[0].Description}");
                    Console.WriteLine();
                    Console.WriteLine("Press any to go back to the main menu");
                    Console.ReadKey();
                    return MainMenu();

                case '2':
                    Console.Clear();
                    Console.WriteLine(_phones[1].Brand + "\x020" + _phones[1].pType + "\x020 \u20AC" + _phones[1].Price + "\n" 
                        + _phones[1].Description);
                    Console.WriteLine("Press any to go back to the main menu");
                    Console.ReadKey();
                    return MainMenu();

                case '3':
                    Console.Clear();
                    Console.WriteLine(_phones[2].Brand + "\x020" + _phones[2].pType + "\x020 \u20AC" + _phones[2].Price + "\n" 
                        + _phones[2].Description);
                    Console.WriteLine("Press any to go back to the main menu");
                    Console.ReadKey();
                    return MainMenu();

                case '4':
                    Console.Clear();
                    Console.WriteLine(_phones[3].Brand + "\x020" + _phones[3].pType + "\x020 \u20AC" + _phones[3].Price + "\n" 
                        + _phones[3].Description);
                    Console.WriteLine("Press any to go back to the main menu");
                    Console.ReadKey();
                    return MainMenu();

                case '5':
                    Console.Clear();
                    Console.WriteLine(_phones[4].Brand + "\x020" + _phones[4].pType + "\x020 \u20AC" + _phones[4].Price + "\n" 
                        + _phones[4].Description);
                    Console.WriteLine("Press any to go back to the main menu");
                    Console.ReadKey();
                    return MainMenu();





            }
            
            return true;
        }
    }

}
