using System;

namespace CSharpFuntamentals
{
    public enum ShipingMethod
    {
        regularAirMail=1,
        registeredAirMail=2,
        Express=3
    }

    class Program
    {
        public static void Main(String[] args)
        {
            ShipingMethod method = ShipingMethod.regularAirMail;
            Console.WriteLine((int)method); //casting

            var methodId = 2;
            Console.WriteLine((ShipingMethod)methodId);

            var methodName = "Express";

            var shipmethod= (ShipingMethod) Enum.Parse(typeof(ShipingMethod), methodName);
            Console.WriteLine(shipmethod);
        }
    }
}