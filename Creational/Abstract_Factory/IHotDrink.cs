using System.Linq;
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

        // this break Open Close principle because by each change we should change Code directly :))

        public enum AvailableDrink 
        {
            Tea , Coffee
        }

        //private Dictionary<AvailableDrink , IHotDrinkFactory> factories = 
        //    new Dictionary<AvailableDrink, IHotDrinkFactory>();

        //public HotDrinkMachine()
        //{
        //    foreach(AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
        //    {
        //         var factory = (IHotDrinkFactory)Activator.CreateInstance(
        //             Type.GetType("Design_Patterns.Creational.Abstract_Factory." + Enum.GetName(typeof(AvailableDrink) , drink) +  "Factory"));

        //        factories.Add(drink , factory);
        //    }
        //}    

        //public IHotDrink MakeDrink(AvailableDrink drink , int amount)   
        //{
        //    return factories[drink].Prepare(amount);
        //}

        private List<Tuple<string , IHotDrinkFactory>> factories = 
            new List<Tuple<string, IHotDrinkFactory>>();
         public HotDrinkMachine()
        {
            foreach(var t in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                if (typeof(IHotDrinkFactory).IsAssignableFrom(t) &&
                 !t.IsInterface)
                 {
                    factories.Add(Tuple.Create(
                        t.Name.Replace("Factory" , string.Empty),
                        (IHotDrinkFactory)Activator.CreateInstance(t)
                    ));
                 }
            }
        }

        public IHotDrink MakeDrink(AvailableDrink drink , int amount )
        {
            Console.WriteLine("Available drinks");
            for(var index = 0 ; index < factories.Count ; index++)
            {
                var tuple  = factories[index];
                Console.WriteLine($"{index}: {tuple.Item1}");
            }


            var s = factories.FirstOrDefault(x => x.Item1.Equals(drink.ToString()));
            return s.Item2.Prepare(amount);
            //return factories[i].Item2.Prepare(amount);

            //while (true)
            //{
            //    string s ;
            //    if ((s = Console.ReadLine()) != null
            //     && int.TryParse(s , out int i )
            //     && i >= 0 
            //     && i < factories.Count)
            //     {
            //        Console.WriteLine("Specify amount : ");
            //        s = Console.ReadLine();
            //        if (s != null
            //            && int.TryParse(s , out int amount)
            //            && amount > 0)
            //            {
            //                return factories[i].Item2.Prepare(amount);
            //            }
            //     }

            //     Console.WriteLine("Incorect input , try again");
            //     Console.ReadKey();
            //}
        }
    }
}