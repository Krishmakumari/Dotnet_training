namespace Strings
{
    
    public class Triangle:Shape,IArea
    {
        private double b;
        private double h;

        public Triangle(double b,double height)
        {
            this.b=b;
            this.h=height;
        }

        public double Calculatearea()
        {
            return 0.5*b*h;
        }
    }
}