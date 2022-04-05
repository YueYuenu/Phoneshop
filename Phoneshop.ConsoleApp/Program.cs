using System;
using System.Collections.Generic;

namespace Phoneshop.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

            var Phones = new List<string>();
            Phones.Add(new Phone1 {Brand = "Huawei", pType = "P30", Price = "697", Description = "6.47iinch FHD + (2340x1080) OLED, Kirin 980 Octa - Core(2x Cortex - A76 2.6GHz + 2x Cortex - A76 1.92GHz + 4x Cortex - A55 1.8GHz), 8GB RAM, 128GB ROM, 40 + 20 + 8 + TOF / 32MP, Dual SIM, 4200mAh, Android 9.0 + EMUI 9.1" });
            Phones.Add(new Phone2 { Brand = "Samsung", pType = "Galaxy A52", Price = "399", Description = "64 megapixel camera, 4k videokwaliteit 6.5 inch AMOLED scherm 128 GB opslaggeheugen (Uitbreidbaar met Micro-sd) Water- en stofbestendig (IP67)" });
            Phones.Add(new Phone3 { Brand = "Apple", pType = "IPhone 11", Price = "619", Description = "Met de dubbele camera schiet je in elke situatie een perfecte foto of video De krachtige A13-chipset zorgt voor razendsnelle prestaties Met Face ID hoef je enkel en alleen naar je toestel te kijken om te ontgrendelen Het toestel heeft een lange accuduur dankzij een energiezuinige processor" });
            Phones.Add(new Phone4 { Brand = "Google", pType = "Pixel 4a", Price = "411", Description = "12.2 megapixel camera, 4k videokwaliteit 5.81 inch OLED scherm 128 GB opslaggeheugen 3140 mAh accucapaciteit" });
            Phones.Add(new Phone5 { Brand = "Xiaomi", pType = "Redmi Note 10 Pro", Price = "298", Description = "108 megapixel camera, 4k videokwaliteit 6.67 inch AMOLED scherm 128 GB opslaggeheugen (Uitbreidbaar met Micro-sd) Water- en stofbestendig (IP53)" });
        }

        private static bool MainMenu(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Please choose the desired phone by pressing the corresponding number \n 1. Huawei P30\n 2. Samsung Galaxy A52\n 3. apple IPhone 11 \n 4. Google Pixel 4a \n 5. Xiaomi Redmi Note 10 Pro");
            var phones = Console.ReadLine();

            switch (Phones)
            {
                case "1":
                    Console.WriteLine(Phone1);
                    break;

                case "2":

                    break;

                case "3":

                    break;

                case "4":

                    break;

                case "5":

                    break;

            }

        }
    }
}
