namespace Design_Patterns.Creational.Builder.Recursive_Generic_Builder
{
    public class Person
    {
        public string Name ; 
        public string Position ;
        public string Phone ;
        public string WorkPhone;

        public class Builder : PersonJobBuilder<Builder>
        {
            
        }

        public static Builder New => new Builder();

        public override string ToString()
        {
            return $"{nameof(Name)} : {Name} , {nameof(Position)} : {Position}";
        }
    }



}