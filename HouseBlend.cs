namespace CoffeeDecorator {
    public class HouseBlend : IBeverage {

        private double cost = 1.99;
        private string description = "Espresso";

        public string Description() {
            return description;
        }

        public double Cost() {
            return cost;
        }
    }
}