using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.RestaurantMenuExample
{
    public abstract class MealFactory
    {
        public abstract Side CreateSide();
        public abstract Mains CreateMain();
        public abstract Drink CreateDrink();
    }
}
