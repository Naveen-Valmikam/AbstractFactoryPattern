using System;

namespace AbstractFactory.DoFactoryExample
{
    class MainApp
    {

        public static void Main1()
        {
            ContinentFactory continent = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(continent);
            world.RunFoodChain();

            continent = new AmericaFactory();
            world = new AnimalWorld(continent);
            world.RunFoodChain();

            Console.ReadKey();

        }
    }
}
