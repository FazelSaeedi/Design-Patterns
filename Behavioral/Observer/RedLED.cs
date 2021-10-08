using System;

namespace Design_Patterns.Behavioral.Observer
{
    public class RedLED : Observer
    {
        private bool _on = false;
        public override void Update()
        {
            _on = !_on;
            Console.WriteLine($"Red LED is {((_on) ? "On" : "Off")}");
        }
    }
}
