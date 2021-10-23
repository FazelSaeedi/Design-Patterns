using System;
using Design_Patterns.Creational.Builder.Builder;
using Design_Patterns.Creational.Builder.LifeWithoutBuilder;

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
    }
}