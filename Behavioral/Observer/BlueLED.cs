using System;

namespace Design_Patterns.Behavioral.Observer
{
    public class BlueLED : Observer
    {
        private bool _on = false;
        public override void Update()
        {
            _on = !_on;
            Console.WriteLine($"Blue LED is {((_on) ? "On" : "Off")}");
        }
    }
}
