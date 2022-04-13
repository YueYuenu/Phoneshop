using Phoneshop.ConsoleApp._1._Phoneshop.Business;
using System;
using System.Linq;
using System.Text;

namespace Phoneshop.ConsoleApp
{
    internal class Program
    {

        static public List<Phone> _phones = new();


        static void Main()
        {
            bool showMenu = true;

            //add phones to list
            _phones.Add(new Phone { Brand = "Huawei", pType = "P30", Price = "697", Description = "6.47inch FHD + (2340x1080) OLED, Kirin 980 Octa - Core(2x Cortex - A76 2.6GHz + 2x Cortex - A76 1.92GHz + 4x Cortex - A55 1.8GHz), 8GB RAM, 128GB ROM, 40 + 20 + 8 + TOF / 32MP, Dual SIM, 4200mAh, Android 9.0 + EMUI 9.1" });
            _phones.Add(new Phone { Brand = "Samsung", pType = "Galaxy A52", Price = "399", Description = "64 megapixel camera, 4k videokwaliteit 6.5 inch AMOLED scherm 128 GB opslaggeheugen (Uitbreidbaar met Micro-sd) Water- en stofbestendig (IP67)" });
            _phones.Add(new Phone { Brand = "Apple", pType = "IPhone 11", Price = "619", Description = "Met de dubbele camera schiet je in elke situatie een perfecte foto of video De krachtige A13-chipset zorgt voor razendsnelle prestaties Met Face ID hoef je enkel en alleen naar je toestel te kijken om te ontgrendelen Het toestel heeft een lange accuduur dankzij een energiezuinige processor" });
            _phones.Add(new Phone { Brand = "Google", pType = "Pixel 4a", Price = "411", Description = "12.2 megapixel camera, 4k videokwaliteit 5.81 inch OLED scherm 128 GB opslaggeheugen 3140 mAh accucapaciteit" });
            _phones.Add(new Phone { Brand = "Xiaomi", pType = "Redmi Note 10 Pro", Price = "298", Description = "108 megapixel camera, 4k videokwaliteit 6.67 inch AMOLED scherm 128 GB opslaggeheugen (Uitbreidbaar met Micro-sd) Water- en stofbestendig (IP53)" });
            
            while (showMenu)
            {
                showMenu = MainMenu();
                Console.ReadLine();
            }


        }

        public static bool MainMenu()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            //TODO zorgen voor iets wat verkeerde input opvangt
            Console.Clear();
            var phoneService = new PhoneService();
            var _phones = phoneService._phones;
            Console.WriteLine("Please choose the desired phone by pressing the corresponding number\n");
            foreach (Phone phone in _phones)
            {
                Console.WriteLine($"{_phones.Count} {_phones[0].Brand} \t{_phones[0].PType}");
            }
            
             //Link to List in PhoneService, getphone?
           

            var userInput = Console.ReadKey(); //TODO kijken of did niet beter kan
            int phones;

            if (char.IsDigit(userInput.KeyChar))
            {
                phones = int.Parse(userInput.KeyChar.ToString());
                Console.Clear();
                Console.WriteLine($"{_phones[0].Brand} {_phones[0].PType} €{_phones[0].PriceVAT} without VAT € - \n{_phones[0].Description}");
                Console.WriteLine("Press any to go back to the main menu\n");
                Console.ReadKey();
                return MainMenu();
            }

            else
            {
                phones = -1;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("User did not input a number");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                return MainMenu();
            }
            
            return true;
        }
    }
}
