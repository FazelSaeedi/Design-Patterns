using System;
using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns.Creational.Builder.Functional_Builder
{
    public abstract class FunctionalBuilder<TSubject , TSelf> 
        where TSelf : FunctionalBuilder<TSubject , TSelf>
        where TSubject : new()
    {
           private readonly List<Func<Person , Person>> actions =
              new List<Func<Person, Person>>();
 
          public TSelf Do(Action<Person> action) => AddAction(action);
 
          public Person Build() 
              => actions.Aggregate(new Person() , (p , f) => f(p));
          private TSelf AddAction(Action<Person> action)
          {
              actions.Add( p => 
              {
                  action(p);
                  return p;
              });
              return (TSelf)this ;
          }
    }



}