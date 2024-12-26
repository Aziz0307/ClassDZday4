using System;

namespace ClassDZday4
{
    public class ElectronicDevice
    {
        private string Brand;
        protected int BatteryLevel;
        private bool IsOn;
        public string GetBrand
        {
            get{return Brand;} 
            set{Brand=value;} 
        }

        public int GetBatteryLevel
        {
            get{return BatteryLevel;}
            set{BatteryLevel=value;}
        }
        public bool GetIsOn
        {
            get{return IsOn;}
            set{IsOn=value;}
        }

        public void Charge(int amount)
        {
            BatteryLevel = amount + BatteryLevel;
            if (BatteryLevel >= 100)
            {
                BatteryLevel = 100;
                Console. WriteLine ($"This device is fully charged 100%");
            }
            else
            {
                Console.WriteLine ($"This device is charging. it's charged {BatteryLevel}%");
            }
        }

        public void StatusDevice()
        {
            if (GetIsOn == true)
            {
                Console.WriteLine($"This device is on.");
            }
            else
            {
                Console.WriteLine ($"This device is off.");
            }
        }
    }
}