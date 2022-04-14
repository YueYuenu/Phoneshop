using Phoneshop.ConsoleApp._1._Phoneshop.Business;
using System;

namespace Phoneshop.ConsoleApp
{
    public class Phone
    {
        public Phone(string brand, string pType, double priceVAT, string description)
        {
            Brand = brand;
            PType = pType;
            PriceVAT = priceVAT;
            Description = description;
            Id = ++_lastUsedIndex;

        }
        private static int _lastUsedIndex = 0;
                           
        public int    Id { get; set; }
        public string Brand { get; set; }
        public string PType { get; set; }
        public double PriceVAT { get; set; }
        public double Price => Math.Round(PriceVAT * 0.79);

        public string Description { get; set; }
    }
}