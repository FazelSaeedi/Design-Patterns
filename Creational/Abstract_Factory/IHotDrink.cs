using System.Collections.Generic;
using System;

namespace Design_Patterns.Creational.Abstract_Factory
{
    public interface IHotDrink
    {
        void Consume();
    }

    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This tea is nice but i'd prefer it with milk.");
        }
    }

    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffee is sensational!");
        }
    }

    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }

    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Put in a tea bag , boil water , pour {amount} ml , add lemon , enjoy!");
            return new Tea();
        }
    }

    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Grind some beans , boil water , pour {amount} ml , add cream and suger , enjoy!");
            return new Coffee();
        }
    }

    public class HotDrinkMachine
    {
        public enum AvailableDrink 
        {
            Tea , Coffee
        }

        private Dictionary<AvailableDrink , IHotDrinkFactory> factories = 
            new Dictionary<AvailableDrink, IHotDrinkFactory>();

        public HotDrinkMachine()
        {
            foreach(AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
            {
                 var factory = (IHotDrinkFactory)Activator.CreateInstance(
                     Type.GetType("Design_Patterns.Creational.Abstract_Factory." + Enum.GetName(typeof(AvailableDrink) , drink) +  "Factory"));

                factories.Add(drink , factory);
            }
        }    

        public IHotDrink MakeDrink(AvailableDrink drink , int amount)   
        {
            return factories[drink].Prepare(amount);
        }
    }
}