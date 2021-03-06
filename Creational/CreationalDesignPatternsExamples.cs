using System.Drawing;
using System;
using Design_Patterns.Creational.Builder.Builder;
using Design_Patterns.Creational.Builder.LifeWithoutBuilder;
using Design_Patterns.Creational.Builder.Recursive_Generic_Builder;
using Design_Patterns.Creational.Builder.Stepwise_Builder;
using Design_Patterns.Creational.Factories;
using Design_Patterns.Creational.Factories.Inner_Factory_Method;
using Design_Patterns.Creational.Abstract_Factory;
using Design_Patterns.Creational.Prototype.Prototype_inheritance;
using t = Design_Patterns.Creational.Prototype.Prototype_Serializer;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Design_Patterns.Creational
{
    public class CreationalDesignPatternsExamples
    {
        public void Run_Life_Without_Builder()
        {
            new LifeWithoutBuilder().Main();
        }

        public void Run_Second_Html_Builder()
        {
            var builder = new HtmlBuilder("ul")
                .AddChild("li" , "hello") // this is fluent interface => each method return type of class
                .AddChild("li" , "world");

            Console.WriteLine(builder.ToString());
        }

        public void Run_Recursive_Generic_Builder()
        {
            var P = Design_Patterns.Creational.Builder.Recursive_Generic_Builder.Person.New
                    .Called("fazel")
                    .WorksAsA("USA")
                    .Phone("090366285660")
                    .WorkPhone("02136250123")
                    .Build();

            Console.WriteLine(P.ToString());                
            
        }

        public void Run_Stepwise_Builder()
        {
                var car = CarBuilder.Create()
                        .OfType(CarType.Crossover)
                        .WithWheels(18)
                        .WithDoorNumber(2)
                        .Build();
                
                Console.WriteLine(car);        
        }

        public void Run_Functional_Builder()
        {
                var person = new Design_Patterns.Creational.Builder.Functional_Builder.PersonBuilder()
                              .Called("fazel")
                              .Position("tehran")
                              .Phone("09366285660")
                              .Build();

                Console.WriteLine(person);                                      
        }

        public void Run_Facets_Builder()
        {
             var pb = new Design_Patterns.Creational.Builder.Faceted_Builder.PersonBuilder();

                    Design_Patterns.Creational.Builder.Faceted_Builder.Person person = pb
                                .Lives
                                    .At("123 London Road")
                                    .In("London")
                                    .WithPostcode("SW12BC")
                                .Works
                                    .At("Fabrikam")
                                    .AsA("Engineer")
                                    .Earning(123000);

                    Console.WriteLine(person);
        }

        public void Run_Factory_Method_Example()
        {

            // when we can use from below method that we implement NewCartesianPoint & NewPolarPoint
            // in pointt class

            //var point = Pointt.NewCartesianPoint(1.0 , Math.PI / 2);
            //Console.WriteLine(point);


            //point = Pointt.NewPolarPoint(1.0 , 15);
            //Console.WriteLine(point);



            // instead of up method we create a PointFactory Class and use it 
            var point = PointFactory.NewPolarPoint(1.0 , Math.PI / 2);
            Console.WriteLine(point);

        }
    
        public void Run_Inner_Factory_Method_Example()
        {
            var point = Pointtt.Factory.NewPolarPoint(1.0 , Math.PI / 2 );
            Console.WriteLine(point);


            // in ravesh equvalent e ba => var originPoint = new Point() 
            // chon private e nmishe new Point konim

            //new Pointtt();  /// -> errorr

            var originPoint = Pointtt.origin();
            
        }

        public void Run_Abstract_Factory_Example()
        {
            //var machine = new HotDrinkMachine();            
            //var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea , 100);
            //drink.Consume();

            //machine.MakeDrink(HotDrinkMachine.AvailableDrink.Coffee , 2000).Consume();



            var machine = new HotDrinkMachine();
            machine.MakeDrink(HotDrinkMachine.AvailableDrink.Coffee , 200).Consume();

            var tea = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea , 100);
            // here we can use from tea object
            tea.Consume();

        }

        public void Run_Prototype_Cloneable_Is_Bad()
        {
            var john = new  Design_Patterns.Creational.Prototype.Employee("John", new  Design_Patterns.Creational.Prototype.Address("123 London Road", "London", "UK"));

            //var chris = john;
            //var chris = new  Design_Patterns.Creational.Prototype.Employee(john);

            //chris.Name = "Chris";

            var chris = john.DeepCopy();
            chris.Address.Country = "Iran" ;
            Console.WriteLine(john); // oops, john is called chris
            Console.WriteLine(chris);

        }

        public void Run_Prototype_Inheritance_Example()
        {
 

            var john = new Design_Patterns.Creational.Prototype.Prototype_inheritance.Employee();
            john.Names = new[] {"John", "Doe"};
            john.Address = new Design_Patterns.Creational.Prototype.Prototype_inheritance.Address {HouseNumber = 123, StreetName = "London Road"};
            john.Salary = 321000;
            var copy = john.DeepCopy();

            copy.Names[1] = "Smith";
            copy.Address.HouseNumber++;
            copy.Salary = 123000;
            
            Console.WriteLine(john);
            Console.WriteLine(copy);

        }

        public void Run_Prototype_Serializer_Example()
        {
            var foo = new Design_Patterns.Creational.Prototype.Prototype_Serializer.Foo {Stuff = 42, Whatever = "abc"};

            //Foo foo2 = foo.DeepCopy(); // crashes without [Serializable]
            Design_Patterns.Creational.Prototype.Prototype_Serializer.Foo foo2 = foo.DeepCopyXml();

            foo2.Whatever = "xyz";
            Console.WriteLine(foo);
            Console.WriteLine(foo2);
            
        }
    }


    // this use for Run_Prototype_Serializer_Example();
    public static class ExtensionMethodss
    {

        public static T DeepCopyXml<T>(this T self)
        {
            using (var ms = new MemoryStream())
            {
                XmlSerializer s = new XmlSerializer(typeof(T));
                s.Serialize(ms, self);
                ms.Position = 0;
                return (T) s.Deserialize(ms);
            }
        }
    }
}