using System;

namespace AbstractFactory.RestaurantMenuExample
{
    public class DinnerMealFactory : MealFactory
    {
        public override Drink CreateDrink()
        {           
           return new Wine();
        }

        public override Mains CreateMain()
        {
            return new Pizza();
        }

        public override Side CreateSide()
        {   
            return new Salad();
        }
    }
}
