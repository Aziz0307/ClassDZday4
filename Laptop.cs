using System;

namespace ClassDZday4
{
    public class Laptop:ElectronicDevice
    {
        public Laptop()
        {
            Console.WriteLine("---First Constructor for laptop (default constructor)---");
            GetBrand = "Lenovo";
            GetBatteryLevel = 30;
            GetIsOn = false;
        }

        public Laptop(string getBrand, int getBatteryLevel, bool getIsOn)
        {
            Console.WriteLine("---Second Constructor for laptop---");
            GetBrand = getBrand;
            GetBatteryLevel = getBatteryLevel;
            GetIsOn = getIsOn;
        }
    }
}