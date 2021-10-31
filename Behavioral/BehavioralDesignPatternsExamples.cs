using Design_Patterns.Behavioral.ChainOfResponsibility;
using Design_Patterns.Behavioral.Command;
using Design_Patterns.Behavioral.Interpreter.Handmade_interpreter;
using Design_Patterns.Behavioral.Observer;
using Design_Patterns.Behavioral.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral
{
    public class BehavioralDesignPatternsExamples
    {
        public void Run_Observer_Example()
        {

            Console.WriteLine("Observer design pattern");
            var greenLed = new GreenLED();
            var redLed = new RedLED();
            var blueLed = new BlueLED();


            var switchKey = new Switch();

            // Refactoring ...
            // switchKey.Attach(greenLed);
            // switchKey.Attach(redLed);
            // switchKey.Attach(blueLed);

            switchKey.AttachList(new List<Observer.Observer> { greenLed , redLed , blueLed });


            switchKey.ChangeState = true;
            switchKey.ChangeState = false;

        }

        public void Run_Strategy_Example()
        {
            SecureContent secureContent = new SecureContent("Fazel Saeedi");

            var Md5Hash = secureContent.hashContent(new MD5Hash());
            var SHA256Hash = secureContent.hashContent(new SHA256Hash());


            Console.WriteLine(BitConverter.ToString(Md5Hash));
            Console.WriteLine(BitConverter.ToString(SHA256Hash));
        }
    
        public void Run_Chain_of_Responsibility_Example()
        {

                var goblin = new Creature("Goblin", 2, 2);
                Console.WriteLine(goblin);
                
                var root = new CreatureModifier(goblin);

                root.Add(new NoBonusesModifier(goblin));

                Console.WriteLine("Let's double goblin's attack...");
                root.Add(new DoubleAttackModifier(goblin));

                Console.WriteLine("Let's increase goblin's defense");
                root.Add(new IncreaseDefenseModifier(goblin));

                // eventually...
                root.Handle();
                Console.WriteLine(goblin);
        }
 
        public void Run_Chain_of_Responsibility_Validation_Example()
        {
            var person = new Design_Patterns.Behavioral.ChainOfResponsibility.Chain_Validation.Person()
            {
                Age = 10 , 
                Income = 15 ,
                Name = "Fazel"
            };

            var reuest = new Design_Patterns.Behavioral.ChainOfResponsibility.Chain_Validation.Request()
            {
                Data = person
            };

            var maxAgeHandler = new Design_Patterns.Behavioral.ChainOfResponsibility.Chain_Validation.MaxAgeHandler();
            var maxNameLenghtHandler = new Design_Patterns.Behavioral.ChainOfResponsibility.Chain_Validation.MaxAgeHandler();
            var maxIcomeHandler = new Design_Patterns.Behavioral.ChainOfResponsibility.Chain_Validation.MaxAgeHandler();

            maxAgeHandler.SetNextHandler(maxNameLenghtHandler);
            maxNameLenghtHandler.SetNextHandler(maxIcomeHandler);
            maxIcomeHandler.Process(reuest);
            reuest.ValidationMessages.ForEach( d => 
            {
                Console.WriteLine(d);
            });



        }
    
        public void Run_Command_Example()
        {
            var bank = new BankAccount();
            var commands = new List<BankAccountCommand>()
            {
                new BankAccountCommand(bank , BankAccountCommand.Action.Withdraw , 100),
                new BankAccountCommand(bank , BankAccountCommand.Action.Deposit , 100),
                new BankAccountCommand(bank , BankAccountCommand.Action.Withdraw , 100 ),
            };

            commands.ForEach(x => x.Call());
           // commands.ForEach(x => x.Undo());

        }

        public void Run_Handmade_interpreter_Example()
        {
             var input = "(13+4)-(12+1)";
             var tokens = Demo.Lex(input);
             Console.WriteLine(string.Join("\t", tokens));

             var parsed = Demo.Parse(tokens);
             Console.WriteLine($"{input} = {parsed.Value}");
        }
    }
}
