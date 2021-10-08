using System;

namespace Design_Patterns.Behavioral.Observer
{
    public class GreenLED : Observer
    {
        private bool _on = false;
        public override void Update()
        {
            _on = !_on;
            Console.WriteLine($"Green LED is {((_on) ? "On" : "Off")}");
        }
    }
}
