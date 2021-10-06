using Design_Patterns.Structural.Bridge;
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

            structuralDesignPatterns.Run_Bridge_Example();
        }
       
    }
    public class StructuralDesignPatternsExamples
    {
        public void Run_Decorator_Example()
        {
            
            Console.WriteLine("Decorator pattern demo");
            MarutiCar mCar = new MarutiCar();
            Console.WriteLine("{0} {1} Regular price: {2}", mCar.GetBrand(), mCar.GetModel(), mCar.GetPrice());



            //Diwali Offer   
            DiwaliOffer dOffer = new DiwaliOffer(mCar);
            Console.WriteLine("{0} {1} Diwali price: {2} after discount of {3} percent", mCar.GetBrand(), mCar.GetModel(), dOffer.NewPrice(), dOffer.PercentDiscount);



            //Holi Offer   
            HoliOffer hOffer = new HoliOffer(mCar);
            Console.WriteLine("{0} {1} Holi price: {2} after discount of {3} percent", mCar.GetBrand(), mCar.GetModel(), hOffer.NewPrice(), hOffer.PercentDiscount);

        }

        public void Run_Bridge_Example()
        {
            Console.WriteLine("Bridge pattern demo");
            
            IEmailSender webService = new WebServiceEmailSender();
            IEmailSender wcf = new WCFEmailSender();
            IEmailSender webApi = new WebAPIEmailSender();

            
            //System Email 
            Email email = new SystemEmail();
            email.Subject = "Test Message";
            email.Body = "Hi there, This is a Test Message from System";


            // ----------------------------------------------------------------------
            email.MessageSender = webService;
            email.Send();


            email.MessageSender = wcf;
            email.Send();


            email.MessageSender = webApi;
            email.Send();


            // User Email ---------------------------------------------------------- 
            
            email = new UserEmail();
            email.Subject = "Test Message";
            email.Body = "Hi there, This is a Test Message from Prakash";

            email.MessageSender = webApi;
            email.Send();


            email.MessageSender = wcf;
            email.Send();


            email.MessageSender = webApi;
            email.Send();

        }
    }
    
}