namespace Design_Patterns.Creational.Factories.Inner_Factory_Method
{

    public class Pointtt
    {
        private double x , y ;
        private Pointtt(double x , double y) 
        // age private bashe to PointFatory nemitonam begiramesh :)) soloution -> inner factory
        // age internal ham konim az dakhel in Library ha ghabel dastresie 
        // age mikhaim private bashe bayad abstract factorisho bebarim dakhel khod class pointt
        {
            this.x = x ;
            this.y = y ;
        }

        public override string ToString()
        {
            return $"{nameof(x)} : {x} ,  {nameof(y)} : {y}";
        }


        // this makes Error
        // public static PointFactory Factory() => new PointFactory();


        // in vase zamanie ke mikhai be class pointtt dastresi dashte bashi chon ke pointtt ye class e ba constructor private :))
        public static Pointtt origin() => new Pointtt(0,0);
        public static Pointtt origin2() => new Pointtt(0,0);

        public static class Factory
        {
            // factory method
            public static Pointtt NewCartesianPoint(double x , double y)
            {
                return new Pointtt(x ,y);
            }

            // factory method
            public static Pointtt NewPolarPoint(double rho , double theta)
            {
                return new Pointtt(rho ,theta);
            }
        }
    }
}