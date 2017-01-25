using AbstractFactory.RestaurantMenuExample;
using System;

namespace AbstractFactory.WithoutDesignRefactoring
{
    public class Kiosk
    {
        public static void Main()
        {
            Console.WriteLine("Please enter your meal type? (B)reakfast or (L)unch or (D)inner:");
            char input = Console.ReadKey().KeyChar;

            MealsProvider mealProvider = new MealsProvider();
            MealOrder order = null;
            bool placeOrder = true;

            switch (input)
            {
                case 'B':
                    order = mealProvider.CreateBreakfast();
                    break;
                case 'L':
                    order = mealProvider.CreateLunch();
                    break;
                case 'D':
                    order = mealProvider.CreateDinner();
                    break;
                default:
                    placeOrder = false;
                    Console.WriteLine("\nSorry we are closed now...");
                    break;
            }

            if (placeOrder)
            {
                var price = order.DisplayPrice();
                Console.WriteLine("\nOrder placed. Please pay $ {0} for your order.", price);
            }
            Console.ReadKey();
        }
    }

    public class MealsProvider
    {
        private MealOrder _meal = new MealOrder();

        public MealOrder CreateBreakfast()
        {
            _meal.Drink = new Juice();
            _meal.Mains = new Sandwich();
            _meal.Side = new Chips();

            return _meal;
        }

        public MealOrder CreateLunch()
        {
            _meal.Drink = new Beer();
            _meal.Mains = new Pasta();
            _meal.Side = new Salad();

            return _meal;
        }

        public MealOrder CreateDinner()
        {
            _meal.Drink = new Wine();
            _meal.Mains = new Pizza();
            _meal.Side = new Salad();

            return _meal;
        }
    }

    public class MealOrder
    {

        public Drink Drink { get; set; }
        public Mains Mains { get; set; }
        public Side Side { get; set; }

        public int DisplayPrice()
        {
            return Drink.Price + Mains.Price + Side.Price;
        }

    }


}
