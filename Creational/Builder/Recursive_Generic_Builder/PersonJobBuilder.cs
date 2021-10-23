namespace Design_Patterns.Creational.Builder.Recursive_Generic_Builder
{
    public class PersonJobBuilder<SELF> 
     : PersonInfoBuilder<PersonJobBuilder<SELF>> 
    where SELF : PersonJobBuilder<SELF>
    {
        public SELF WorksAsA(string position)
        {
            person.Position = position ;
            return (SELF)this ;
        }

        public SELF WorkPhone(string phone)
        {
            person.WorkPhone = phone ;
            return (SELF)this ;
        }
    }



}