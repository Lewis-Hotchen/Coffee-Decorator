namespace CoffeeDecorator {
    public class Milk : CondimentModifierDecorator {

        public override double Cost() {
            return Beverage.Cost() + 0.10;
        }

        public override string Description() {
            return Beverage.Description() + ", Milk";
        }

        public Milk(IBeverage beverage) {
            Beverage = beverage;
        }
    }
}