namespace AbstractFactory.RestaurantMenuExample
{
    public class BreakfastMealFactory : MealFactory
    {
        public override Drink CreateDrink()
        {
            return new Juice();
        }

        public override Mains CreateMain()
        {
            return new Sandwich();
        }

        public override Side CreateSide()
        {
            return new Salad();
        }
    }
}
