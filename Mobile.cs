using System;

namespace ClassDZday4
{
    public class Mobile: ElectronicDevice
    {
        public Mobile()
        {
            Console.WriteLine("---First Constructor for Mobile (default constructor)---");
            GetBrand = "Samsung";
            GetBatteryLevel = 50;
            GetIsOn = true;
        }

        public Mobile(string getBrand, int batterylevel, bool getIsOn)
        {
            Console.WriteLine("---Second Constructor for Mobile---");
            GetBrand = getBrand;
            GetIsOn = getIsOn;
            GetBatteryLevel = batterylevel;
        }
    }
}