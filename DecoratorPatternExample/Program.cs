using DecoratorPatternExample.Addons;
using DecoratorPatternExample.Beverages;
using System;

namespace DecoratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            var caramelEspresso = new CaramelAddOn(espresso);
            var caramelSoyEspresso = new SoyMilkAddOn(caramelEspresso);

            Console.WriteLine($"Espresso: {espresso.CaluculateCost()}");
            Console.WriteLine($"Espresso|Caramel: {caramelEspresso.CaluculateCost()}");
            Console.WriteLine($"Espresso|Soy|Caramel: {caramelSoyEspresso.CaluculateCost()}");
        }
    }
}
