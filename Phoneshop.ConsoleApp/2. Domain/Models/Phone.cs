using Phoneshop.ConsoleApp._1._Phoneshop.Business;

namespace Phoneshop.ConsoleApp
{
    public class Phone
    {
        public int    Id { get; set; }
        public string Brand { get; set; }
        public string PType { get; set; }
        public double PriceVAT { get; set; }
        public double Price => PriceVAT * 0.79;

        public string Description { get; set; }
    }
}