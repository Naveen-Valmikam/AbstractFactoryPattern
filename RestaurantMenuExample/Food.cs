namespace AbstractFactory.RestaurantMenuExample
{
    public class Salad : Side
    {
        public Salad()
        {
            Price = 2;
        }
    }

    public class Chips : Side
    {
        public Chips()
        {
            Price = 3;
        }

    }


    public class Sandwich : Mains
    {
        public Sandwich()
        {
            Price = 7;
        }

    }

    public class Pizza : Mains
    {
        public Pizza()
        {
            Price = 10;
        }

    }

    public class Pasta : Mains
    {
        public Pasta()
        {
            Price = 8;
        }
    }

    public class Juice : Drink
    {
        public Juice()
        {
            Price = 3;
        }
    }

    public class Beer : Drink
    {
        public Beer()
        {
            Price = 4;
        }
    }

    public class Wine : Drink
    {
        public Wine()
        {
            Price = 5;
        }
    }

}

