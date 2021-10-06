using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Facade
{
    public class CarFacade
    {

        private Body body;
        private Engine engine;
        private Tyre tyre;
        private Accessories accessories;


        public CarFacade()
        {
            body = new Body();
            engine = new Engine();
            tyre = new Tyre();
            accessories = new Accessories();
        }



        public void AssembleCar()
        {
            Console.WriteLine("Car Assembling Started...");
            body.AssembleBody();
            engine.AssembleEngine();
            tyre.AssembleTyre();
            accessories.AssembleSeat();
            accessories.AssembleMusicSystem();
            Console.WriteLine("Car Assembling Done...");
        }

    }
}
