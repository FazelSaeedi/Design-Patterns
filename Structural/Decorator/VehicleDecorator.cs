namespace Design_Patterns.Structural.Decorator
{
    ///
    /// The Decorator abstract class   
    ///
    public abstract class VehicleDecorator : IVehicle
    {

        private IVehicle _vehicle;
        
        protected VehicleDecorator(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public string GetBrand() { return _vehicle.GetBrand(); }
        public string GetModel() { return _vehicle.GetModel(); }
        public int GetPrice() { return _vehicle.GetPrice(); }


    }
}
