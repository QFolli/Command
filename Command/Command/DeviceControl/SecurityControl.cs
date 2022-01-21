using System;

namespace Command.DeviceControl
{
    public class SecurityControl
    {
        public void Arm()
        {
            Console.WriteLine("Контроль безопасности:Активирован ");
        }

        public void Disarm()
        {
            Console.WriteLine("Контроль безопасности:Снят ");
        }
    }
}