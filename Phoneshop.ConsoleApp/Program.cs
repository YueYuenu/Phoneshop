using System;
using System.Collections.Generic;

namespace Phoneshop.ConsoleApp
{
    internal class Program
    {   

        static public List<Phone> _phones = new(); //set up list of phones
        


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

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Please choose the desired phone by pressing the corresponding number \n 1. Huawei P30\n 2. Samsung Galaxy A52\n 3. apple IPhone 11 \n 4. Google Pixel 4a \n 5. Xiaomi Redmi Note 10 Pro");
            var phones = Console.ReadLine();


            switch (phones)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(_phones[0].Brand);
                    Console.WriteLine(_phones[0].pType);
                    Console.WriteLine(_phones[0].Price);
                    Console.WriteLine(_phones[0].Description);
                    Console.WriteLine();
                    Console.WriteLine("Press any to go back to the main menu");
                    Console.ReadKey();
                    return MainMenu();

                case "2":
                    Console.Clear();
                    Console.WriteLine(_phones[1].Brand);
                    Console.WriteLine(_phones[1].pType);
                    Console.WriteLine(_phones[1].Price);
                    Console.WriteLine(_phones[1].Description);
                    Console.WriteLine("Press any to go back to the main menu");
                    Console.ReadKey();
                    return MainMenu();

                case "3":
                    Console.Clear();
                    Console.WriteLine(_phones[2].Brand);
                    Console.WriteLine(_phones[2].pType);
                    Console.WriteLine(_phones[2].Price);
                    Console.WriteLine(_phones[2].Description);
                    Console.WriteLine("Press any to go back to the main menu");
                    Console.ReadKey();
                    return MainMenu();

                case "4":
                    Console.Clear();
                    Console.WriteLine(_phones[3].Brand);
                    Console.WriteLine(_phones[3].pType);
                    Console.WriteLine(_phones[3].Price);
                    Console.WriteLine(_phones[3].Description);
                    Console.WriteLine("Press any to go back to the main menu");
                    Console.ReadKey();
                    return MainMenu();

                case "5":
                    Console.Clear();
                    Console.WriteLine(_phones[4].Brand);
                    Console.WriteLine(_phones[4].pType);
                    Console.WriteLine(_phones[4].Price);
                    Console.WriteLine(_phones[4].Description);
                    Console.WriteLine("Press any to go back to the main menu");
                    Console.ReadKey();
                    return MainMenu();





            }
            
            return true;
        }
    }
}
