namespace Design_Patterns.Creational.Builder.Functional_Builder
{

    public sealed class PersonBuilder : FunctionalBuilder<Person , PersonBuilder>
    {
        public PersonBuilder Called (string name)
            => Do(p => p.Name = name);

        public PersonBuilder Position (string position)
            => Do(p => p.Position = position);   

        public PersonBuilder Phone(string phone)
            => Do(p => p.Phone = phone);           
    }

}