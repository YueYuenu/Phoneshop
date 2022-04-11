namespace Phoneshop.ConsoleApp

    public class Phone
    {
        public int    Id { get; set; }
        public string Brand { get; set; }
        public string pType { get; set; }
        public string PriceVAT { get; set; }
        public string Price { get; return PriceVAT * 0.79 }
        public string Description { get; set; }
    }


