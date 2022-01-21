using System;
using System.Collections.Generic;
using System.Text;

namespace Command.DeviceControl
{
    public class Hottub
    {
        public void Circulate()
        {
            Console.WriteLine("Джакузи: циркуляция");
        }

        public void JetsOn()
        {
            Console.WriteLine("Джакузи:Вода включена");
        }
        public void JetsOff()
        {
            Console.WriteLine("Джакузи:Вода выключена");
        }

        public void SetTemperature(int value)
        {
            Console.WriteLine($"Джакузи:температура воды сейчас: {value}");
        }
    }
}
