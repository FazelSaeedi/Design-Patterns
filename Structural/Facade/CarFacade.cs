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


        public CarFacade(Body body, Engine engine, Tyre tyre, Accessories accessories)
        {
            this.body = body;
            this.engine = engine;
            this.tyre = tyre;
            this.accessories = accessories;
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
