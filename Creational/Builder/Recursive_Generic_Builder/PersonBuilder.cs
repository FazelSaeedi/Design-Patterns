namespace Design_Patterns.Creational.Builder.Recursive_Generic_Builder
{
    public abstract class PersonBuilder
    {
        protected Person person = new Person();
        public Person Build() 
        {
            return person;
        }

    }
}