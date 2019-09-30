namespace CoffeeDecorator {
    public class Mocha : CondimentModifierDecorator {

        public override double Cost() {
            return Beverage.Cost() + 0.50;
        }

        public override string Description() {
            return Beverage.Description() + ", Mocha";
        }

        public Mocha(IBeverage beverage) {
            Beverage = beverage;
        }
    }
}