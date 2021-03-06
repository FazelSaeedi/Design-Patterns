using System.Security.Cryptography;
using Design_Patterns.Behavioral.ChainOfResponsibility;
using Design_Patterns.Behavioral.Command;
using Design_Patterns.Behavioral.Interpreter.Handmade_interpreter;
using Design_Patterns.Behavioral.Iterator;
using Design_Patterns.Behavioral.Observer;
using Design_Patterns.Behavioral.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns.Behavioral.NullObject;

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
            var bank = new Design_Patterns.Behavioral.Command.BankAccount();
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

        public void Run_Iterator_Example()
        {
            // The client code may or may not know about the Concrete Iterator
            // or Collection classes, depending on the level of indirection you
            // want to keep in your program.
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    
        public void Run_Mediator_Chatroom_Example()
        {
            
        
               var room = new Design_Patterns.Behavioral.Mediator.ChatRoom();

                var john = new Design_Patterns.Behavioral.Mediator.Person("John");
                var jane = new Design_Patterns.Behavioral.Mediator.Person("Jane");

                room.Join(john);
                room.Join(jane);

                john.Say("hi room");
                jane.Say("oh, hey john");

                var simon = new Design_Patterns.Behavioral.Mediator.Person("Simon");
                room.Join(simon);
                simon.Say("hi everyone!");

                jane.PrivateMessage("Simon", "glad you could join us!");
        }
    
        public void Run_Memento_Bank_Example()
        {
                // var ba = new Design_Patterns.Behavioral.Memento.BankAccounting.BankAccount(100);
                // var m1 = ba.Deposit(50); // 150
                // var m2 = ba.Deposit(25); // 175
                // Console.WriteLine(ba);

                // // restore to m1
                // ba.Restore(m1);
                // Console.WriteLine(ba);

                // ba.Restore(m2);
                // Console.WriteLine(ba);


                 var ba = new Design_Patterns.Behavioral.Memento.BankAccounting.BankAccount(100);
                 ba.Deposit(50);
                 ba.Deposit(25);
                 Console.WriteLine(ba);
                 ba.Undo();
                 Console.WriteLine($"Undo 1: {ba}");
                 ba.Undo();
                 Console.WriteLine($"Undo 2: {ba}");
                 ba.Redo();
                 Console.WriteLine($"Redo 2: {ba}");
        }    
 
        public void Run_NullObjedt_Example()
        {
                  //var log = new ConsoleLog();
                    //ILog log = null;
                    //var log = new NullLog();
                    var log = Null<ILog>.Instance;
                    var ba = new Design_Patterns.Behavioral.NullObject.BankAccount(log);
                    ba.Deposit(100);
                    ba.Withdraw(200);
        }
        public interface IMyInterface
        {
            public string s{get;set;}
        }
    }
}
