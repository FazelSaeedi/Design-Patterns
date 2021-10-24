using Design_Patterns.Behavioral;
using Design_Patterns.Creational;
using Design_Patterns.Structural;


namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            // Structural design patterns -----------------------------------------------

            var structuralDesignPatterns = new StructuralDesignPatternsExamples();

            // structuralDesignPatterns.Run_Decorator_Example();
            // structuralDesignPatterns.Run_Bridge_Example();
            // structuralDesignPatterns.Run_Facade_Example();
            // structuralDesignPatterns.Run_Proxy_Exampple();
            // structuralDesignPatterns.Run_Adapter_Example();
            // structuralDesignPatterns.Run_Composite_Example();

            // Behavioral design patterns -----------------------------------------------

            var behavioralDesignPatterns = new BehavioralDesignPatternsExamples();

            // behavioralDesignPatterns.Run_Observer_Example();
            // behavioralDesignPatterns.Run_Strategy_Example();
            

            // Creational Design Patterns -----------------------------------------------

            var creationalDesignPatterns = new CreationalDesignPatternsExamples();

            creationalDesignPatterns.Run_Life_Without_Builder();
            creationalDesignPatterns.Run_Second_Html_Builder();
            creationalDesignPatterns.Run_Recursive_Generic_Builder();
            creationalDesignPatterns.Run_Stepwise_Builder();
            creationalDesignPatterns.Run_Functional_Builder();
            creationalDesignPatterns.Run_Facets_Builder();


            creationalDesignPatterns.Run_Factory_method_Example();
        }
       
    }

    
}