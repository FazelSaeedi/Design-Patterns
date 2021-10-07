using Design_Patterns.Structural.Bridge;
using Design_Patterns.Structural.Decorator;
using Design_Patterns.Structural.Facade;
using Design_Patterns.Structural.Proxy;
using System;
using System.IO;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            var structuralDesignPatterns = new StructuralDesignPatternsExamples();

            structuralDesignPatterns.Run_Decorator_Example();
            structuralDesignPatterns.Run_Bridge_Example();
            structuralDesignPatterns.Run_Facade_Example();
            structuralDesignPatterns.Run_Proxy_Exampple();

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

        public void Run_Facade_Example()
        {
            Console.WriteLine("Facade pattern demo");
            CarFacade carFacade = new CarFacade();
            carFacade.AssembleCar();
        }

        public void Run_Proxy_Exampple()
        {
            Console.WriteLine("Proxy pattern demo");
            IFilesService filesService = new FilesServicesProxy();
            filesService.WritePersonInFile("c:\\myfakepath\\a.txt", "Fazel", "Saeedi", 26);

            var directory = filesService.GetDirectoryInfo("d:\\myrightpath\\");
            var fileName = Path.Combine(directory.FullName, "dotnettips.txt");

            filesService.WritePersonInFile(fileName, "fa", "Saeedi", 26);
            filesService.WritePersonInFile(fileName, "Fazel", "Saeedi", 12);
            filesService.WritePersonInFile(fileName, "Fazel", "Saeedi", 26);

            filesService.DeleteFile("c:\\myfakefile.txt");
            filesService.DeleteFile(fileName);
        }
    }
    
}