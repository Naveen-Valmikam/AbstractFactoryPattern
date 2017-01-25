using System;

namespace AbstractFactory.RestaurantMenuExample
{
    public class Kiosk
    {

        public static void Main2()
        {

            Console.WriteLine("Please enter your meal type? (B)reakfast or (L)unch or (D)inner:");
            char input = Console.ReadKey().KeyChar;

            MealFactory meal = null;

            bool placeOrder = true;

            switch (input)
            {
                case 'B':
                    meal = new BreakfastMealFactory();
                    break;
                case 'L':
                    meal = new LunchMenuFactory();
                    break;
                case 'D':
                    meal = new DinnerMealFactory();
                    break;
                default:
                    placeOrder = false;
                    Console.WriteLine("\nSorry we are closed now...");
                    break;
            }

            if (placeOrder)
            {
                var order = new MealOrder(meal);
                var price = order.DisplayPrice();
                Console.WriteLine("\nOrder placed. Please pay $ {0} for your order.", price);
            }
            Console.ReadKey();

        }
    }
}
