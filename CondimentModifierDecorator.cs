namespace CoffeeDecorator {
    public class CondimentModifierDecorator : IBeverage {
        public IBeverage Beverage { get; set; }

        public virtual string Description() {
            return Beverage.Description();
        }

        public virtual double Cost() {
            return Beverage.Cost();
        }
    }
}