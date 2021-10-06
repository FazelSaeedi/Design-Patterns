namespace Design_Patterns.Structural.Decorator
{


    ///
    /// The concrete component  
    ///
    public class HyundaiCar : IVehicle
    {
     
        public string GetBrand() { return "Hyundai"; }
        public string GetModel() { return "Grand i10 Magna"; }
        public int GetPrice(){ return 540000; }

    }
}
