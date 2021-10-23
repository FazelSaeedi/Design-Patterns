namespace Design_Patterns.Creational.Builder.Stepwise_Builder
{
    public interface ISpecifyCarType
  {
    public ISpecifyWheelSize OfType(CarType type);
  }

}