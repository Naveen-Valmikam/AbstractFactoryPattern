namespace AbstractFactory.RestaurantMenuExample
{
    public class LunchMenuFactory : MealFactory
    {
        public override Drink CreateDrink()
        {
            return new Beer();
        }

        public override Mains CreateMain()
        {
            return new Pasta();
        }

        public override Side CreateSide()
        {
            return new Chips();
        }
    }
}
