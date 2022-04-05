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
            Phones.Add(new Phone1 {Brand = "", pType = "", Price = "", Description = "" });
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
