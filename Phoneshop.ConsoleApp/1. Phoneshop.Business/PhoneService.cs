﻿using System.Collections.Generic;

namespace Phoneshop.ConsoleApp._1._Phoneshop.Business
{
    public class PhoneService
    {
        public List<Phone> _phones = new()
        {

            new Phone
            (
                "Huawei",
                "P30",
                 697,
                 "6.47inch FHD + (2340x1080) OLED, Kirin 980 Octa - Core(2x Cortex - A76 2.6GHz + 2x Cortex - A76 1.92GHz + 4x Cortex - A55 1.8GHz), 8GB RAM, 128GB ROM,"
                + "40 + 20 + 8 + TOF / 32MP, Dual SIM, 4200mAh, Android 9.0 + EMUI 9.1"
            ),

            new Phone
            (
               "Samsung",
                "Galaxy A52",
                399,
                "64 megapixel camera, 4k videokwaliteit 6.5 inch AMOLED scherm 128 GB opslaggeheugen (Uitbreidbaar met Micro-sd) Water- en stofbestendig (IP67)"
            ),

            new Phone
            (
                "Apple",
                "IPhone 11",
                619,
                "Met de dubbele camera schiet je in elke situatie een perfecte foto of video De krachtige A13-chipset zorgt voor razendsnelle prestaties Met Face ID " +
                "hoef je enkel en alleen naar je toestel te kijken om te ontgrendelen Het toestel heeft een lange accuduur dankzij een energiezuinige processor"
            ),
            new Phone
            (
                "Google",
                "Pixel 4a",
                411,
                "12.2 megapixel camera, 4k videokwaliteit 5.81 inch OLED scherm 128 GB opslaggeheugen 3140 mAh accucapaciteit"
            ),
            new Phone
            (
                "Xiaomi",
                "Redmi Note 10 Pro",
                298,
                "108 megapixel camera, 4k videokwaliteit 6.67 inch AMOLED scherm 128 GB opslaggeheugen (Uitbreidbaar met Micro-sd) Water- en stofbestendig (IP53)"
            )

        };
    }
}
