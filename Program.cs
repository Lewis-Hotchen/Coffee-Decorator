using System;

namespace CoffeeDecorator {
    class Program {
        static void Main(string[] args) {
            IBeverage beverage = new Espresso();
            beverage = new Milk(beverage);
            Console.WriteLine(beverage.Description() + " £" + beverage.Cost());

            IBeverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Milk(beverage2);
            Console.WriteLine(beverage2.Description() + " £" + beverage2.Cost());

        }
    }
}
