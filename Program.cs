using Design_Patterns.Behavioral;
using Design_Patterns.Structural;


namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            // Structural design patterns -----------------------------------------------

            var structuralDesignPatterns = new StructuralDesignPatternsExamples();

            structuralDesignPatterns.Run_Decorator_Example();
            structuralDesignPatterns.Run_Bridge_Example();
            structuralDesignPatterns.Run_Facade_Example();
            structuralDesignPatterns.Run_Proxy_Exampple();
            structuralDesignPatterns.Run_Adapter_Example();

            // Behavioral design patterns -----------------------------------------------

            var behavioralDesignPatterns = new BehavioralDesignPatternsExamples();

            behavioralDesignPatterns.Run_Observer_Example();
            behavioralDesignPatterns.Run_Strategy_Example();

        }
       
    }

    
}