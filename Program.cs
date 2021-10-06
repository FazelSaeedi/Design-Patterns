using Design_Patterns.Structural.Decorator;
using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            var structuralDesignPatterns = new StructuralDesignPatternsExamples();

            structuralDesignPatterns.Run_Decorator_Example();

        }
       
    }
    public class StructuralDesignPatternsExamples
    {
        public void Run_Decorator_Example()
        {
            
            Console.Title = "Decorator pattern demo";
            MarutiCar mCar = new MarutiCar();
            Console.WriteLine("{0} {1} Regular price: {2}", mCar.GetBrand(), mCar.GetModel(), mCar.GetPrice());



            //Diwali Offer   
            DiwaliOffer dOffer = new DiwaliOffer(mCar);
            Console.WriteLine("{0} {1} Diwali price: {2} after discount of {3} percent", mCar.GetBrand(), mCar.GetModel(), dOffer.NewPrice(), dOffer.PercentDiscount);



            //Holi Offer   
            HoliOffer hOffer = new HoliOffer(mCar);
            Console.WriteLine("{0} {1} Holi price: {2} after discount of {3} percent", mCar.GetBrand(), mCar.GetModel(), hOffer.NewPrice(), hOffer.PercentDiscount);

        }
    }
}