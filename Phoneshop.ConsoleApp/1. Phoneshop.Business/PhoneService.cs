using Phoneshop.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoneshop.ConsoleApp._1._Phoneshop.Business
{
    public class PhoneService
    {
        public List<Phone> _phones = new();
        _phones.Add(new Phone 
                { 
                    Id =1
                    Brand = "Huawei", 
                    PType = "P30", 
                    PriceVAT = "697", 
                    Description = "6.47inch FHD + (2340x1080) OLED, Kirin 980 Octa - Core(2x Cortex - A76 2.6GHz + 2x Cortex - A76 1.92GHz + 4x Cortex - A55 1.8GHz), 8GB RAM, 128GB ROM," 
                    + "40 + 20 + 8 + TOF / 32MP, Dual SIM, 4200mAh, Android 9.0 + EMUI 9.1" 
                });

                _phones.Add(new Phone 
                { 
                    Brand = "Samsung", 
                    PType = "Galaxy A52", 
                    PriceVAT = "399", 
                    Description = "64 megapixel camera, 4k videokwaliteit 6.5 inch AMOLED scherm 128 GB opslaggeheugen (Uitbreidbaar met Micro-sd) Water- en stofbestendig (IP67)" 
                });

_phones.Add(new Phone
{
    Brand = "Apple",
    PType = "IPhone 11",
    PriceVAT = "619",
    Description = "Met de dubbele camera schiet je in elke situatie een perfecte foto of video De krachtige A13-chipset zorgt voor razendsnelle prestaties Met Face ID " +
    "hoef je enkel en alleen naar je toestel te kijken om te ontgrendelen Het toestel heeft een lange accuduur dankzij een energiezuinige processor"
});
_phones.Add(new Phone
{
    Brand = "Google",
    PType = "Pixel 4a",
    PriceVAT = "411",
    Description = "12.2 megapixel camera, 4k videokwaliteit 5.81 inch OLED scherm 128 GB opslaggeheugen 3140 mAh accucapaciteit"
});
_phones.Add(new Phone
{
    Brand = "Xiaomi",
    PType = "Redmi Note 10 Pro",
    PriceVAT = "298",
    Description = "108 megapixel camera, 4k videokwaliteit 6.67 inch AMOLED scherm 128 GB opslaggeheugen (Uitbreidbaar met Micro-sd) Water- en stofbestendig (IP53)"
});

        




    }
}
