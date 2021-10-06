namespace Design_Patterns.Structural.Decorator
{

    //  ConcreteDecorator
    public class HoliOffer : VehicleDecorator

    {

        public HoliOffer(IVehicle vehicle): base(vehicle) { }
        public int PercentDiscount = 15;
        public int NewPrice()
        {
            return base.GetPrice() * (100 - PercentDiscount) / 100;
        }

    }

}
