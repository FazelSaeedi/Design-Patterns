using System;

namespace Design_Patterns.Structural.Composite
{
    public class Leaf : Component
    {
        public void Operation()
        {
            Console.WriteLine("Leaf");
        }
    }

}
