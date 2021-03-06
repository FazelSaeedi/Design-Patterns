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

            structuralDesignPatterns.Run_Decorator_Example();
            structuralDesignPatterns.Run_Bridge_Example();
            structuralDesignPatterns.Run_Facade_Example();
            //structuralDesignPatterns.Run_Proxy_Exampple();
            structuralDesignPatterns.Run_Adapter_Example();
            //structuralDesignPatterns.Run_Composite_Example();
            structuralDesignPatterns.Run_Adapter_No_Cashing_Example();
            structuralDesignPatterns.Run_Generic_value_Adapter();
            structuralDesignPatterns.Run_Dependency_Injection_Adapter_Example();
            structuralDesignPatterns.Run_Bridge_Book_Example();
            structuralDesignPatterns.Run_FlyWeight_Repeating_User_Names();
            structuralDesignPatterns.Run_Text_Formatting_FlyWeight_Example();

            // Behavioral design patterns -----------------------------------------------

            var behavioralDesignPatterns = new BehavioralDesignPatternsExamples();

            // behavioralDesignPatterns.Run_Observer_Example();
            // behavioralDesignPatterns.Run_Strategy_Example();
            behavioralDesignPatterns.Run_Chain_of_Responsibility_Example();
            behavioralDesignPatterns.Run_Chain_of_Responsibility_Validation_Example();
            behavioralDesignPatterns.Run_Command_Example();
            behavioralDesignPatterns.Run_Handmade_interpreter_Example();
            behavioralDesignPatterns.Run_Iterator_Example();
            behavioralDesignPatterns.Run_Mediator_Chatroom_Example();
            behavioralDesignPatterns.Run_Memento_Bank_Example();
            behavioralDesignPatterns.Run_NullObjedt_Example();

            // Creational Design Patterns -----------------------------------------------

            var creationalDesignPatterns = new CreationalDesignPatternsExamples();

            creationalDesignPatterns.Run_Life_Without_Builder();
            creationalDesignPatterns.Run_Second_Html_Builder();
            creationalDesignPatterns.Run_Recursive_Generic_Builder();
            creationalDesignPatterns.Run_Stepwise_Builder();
            creationalDesignPatterns.Run_Functional_Builder();
            creationalDesignPatterns.Run_Facets_Builder();


            creationalDesignPatterns.Run_Factory_Method_Example();
            creationalDesignPatterns.Run_Inner_Factory_Method_Example();
            creationalDesignPatterns.Run_Abstract_Factory_Example();
            
            creationalDesignPatterns.Run_Prototype_Cloneable_Is_Bad();
            creationalDesignPatterns.Run_Prototype_Inheritance_Example();
            creationalDesignPatterns.Run_Prototype_Serializer_Example();
        }
       
    }

    
}