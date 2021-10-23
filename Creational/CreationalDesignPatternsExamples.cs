using System;
using Design_Patterns.Creational.Builder.Builder;
using Design_Patterns.Creational.Builder.LifeWithoutBuilder;
using Design_Patterns.Creational.Builder.Recursive_Generic_Builder;
using Design_Patterns.Creational.Builder.Stepwise_Builder;

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
            var P = Person.New
                    .Called("fazel")
                    .WorksAsA("USA")
                    .Build();

            Console.WriteLine(P.ToString());                
            
        }

        public void Run_Stepwise_Builder()
        {
                var car = CarBuilder.Create()
                        .OfType(CarType.Crossover)
                        .WithWheels(18)
                        .Build();
                
                Console.WriteLine(car);        
        }

        public void Run_Functional_Builder()
        {
                var person = new Design_Patterns.Creational.Builder.Functional_Builder.PersonBuilder()
                              .Called("fazel")
                              .Position("tehran")
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
    }
}