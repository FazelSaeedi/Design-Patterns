namespace Design_Patterns.Structural.Decorator
{

    //  ConcreteDecorator
    public class DiwaliOffer : VehicleDecorator
    {

        public DiwaliOffer(IVehicle vehicle) : base(vehicle) { }
        public int PercentDiscount = 20;
        public int NewPrice()
        {
            return base.GetPrice() * (100 - PercentDiscount) / 100;
        }

    }

}
