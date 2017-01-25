namespace AbstractFactory.RestaurantMenuExample
{
    public class MealOrder
    {
        private Drink _drink;
        private Mains _mains;
        private Side _side;

        public MealOrder(MealFactory factory)
        {
            _drink = factory.CreateDrink();
            _mains = factory.CreateMain();
            _side = factory.CreateSide();
        }

        public int DisplayPrice()
        {
            return _drink.Price + _mains.Price + _side.Price;
        }

    }
}
