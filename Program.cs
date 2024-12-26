using System;

namespace ClassDZday4
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobile mobile = new Mobile();
            Console.WriteLine($"Mobile brand: {mobile.GetBrand}  The battery level: {mobile.GetBatteryLevel}");
            mobile.StatusDevice();
            mobile.Charge(20);
            Laptop laptop = new Laptop();
            Console.WriteLine($"Laptop brand: {laptop.GetBrand}  The battery level: {laptop.GetBatteryLevel}");
            laptop.StatusDevice();
            laptop.Charge(10);
            Mobile mobile2 = new Mobile("Huawei",20,true);
            Console.WriteLine($"Mobile brand: {mobile2.GetBrand}  The battery level: {mobile2.GetBatteryLevel}");
            mobile2.StatusDevice();
            mobile2.Charge(90);
            Laptop laptop2 = new Laptop("Asus",15,true);
            Console.WriteLine($"Laptop brand: {laptop2.GetBrand}  The battery level: {laptop2.GetBatteryLevel}");
            laptop2.StatusDevice();
            laptop2.Charge(10);
        }
    }
}