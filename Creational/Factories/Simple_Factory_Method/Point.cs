namespace Design_Patterns.Creational.Factories
{
    public class PointFactory
    {
        // factory method
        public static Pointt NewCartesianPoint(double x , double y)
        {
            return new Pointt(x ,y);
        }

        // factory method
        public static Pointt NewPolarPoint(double rho , double theta)
        {
            return new Pointt(rho ,theta);
        }
    }
    public class Pointt
    {
        private double x , y ;
        public Pointt(double x , double y)  // age private bashe to PointFatory nemitonam begiramesh :))
        // age mikhaim private bashe bayad abstract factorisho bebarim dakhel khod class pointt
        {
            this.x = x ;
            this.y = y ;
        }

        public override string ToString()
        {
            return $"{nameof(x)} : {x} ,  {nameof(y)} : {y}";
        }
    }

}