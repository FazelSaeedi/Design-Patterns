using Design_Patterns.Behavioral.Observer;
using Design_Patterns.Behavioral.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral
{
    public class BehavioralDesignPatternsExamples
    {
        public void Run_Observer_Example()
        {

            Console.WriteLine("Observer design pattern");
            var greenLed = new GreenLED();
            var redLed = new RedLED();
            var blueLed = new BlueLED();


            var switchKey = new Switch();

            // Refactoring ...
            // switchKey.Attach(greenLed);
            // switchKey.Attach(redLed);
            // switchKey.Attach(blueLed);

            switchKey.AttachList(new List<Observer.Observer> { greenLed , redLed , blueLed });


            switchKey.ChangeState = true;
            switchKey.ChangeState = false;

        }

        public void Run_Strategy_Example()
        {
            SecureContent secureContent = new SecureContent("Fazel Saeedi");

            var Md5Hash = secureContent.hashContent(new MD5Hash());
            var SHA256Hash = secureContent.hashContent(new SHA256Hash());


            Console.WriteLine(BitConverter.ToString(Md5Hash));
            Console.WriteLine(BitConverter.ToString(SHA256Hash));
        }
    }
}
