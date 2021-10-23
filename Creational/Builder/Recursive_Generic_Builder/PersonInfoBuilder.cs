namespace Design_Patterns.Creational.Builder.Recursive_Generic_Builder
{
    public class PersonInfoBuilder<SELF> 
    : PersonBuilder 
    where SELF : PersonInfoBuilder<SELF>
    {
        public SELF Called(string name)
        {
            person.Name = name ;
            return (SELF) this;
        }

        public SELF Phone(string phone)
        {
            person.Phone = phone ;   
            return (SELF)this ;
        }
    }



}