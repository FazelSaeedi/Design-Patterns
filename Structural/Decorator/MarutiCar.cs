namespace Design_Patterns.Structural.Decorator
{

    ///
    /// The concrete component  
    ///
    public class MarutiCar : IVehicle
    {

        public string GetBrand() {  return "Maruti"; }
        public string GetModel() { return "Swift VXI"; }
        public int GetPrice() { return 610000; }

    }
}
