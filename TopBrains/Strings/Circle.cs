namespace Strings
{
    
    public class Circle:Shape,IArea
    {
        private double radius;

        public Circle(double r)
        {
            radius=r;
        }

        public double Calculatearea()
        {
            return Math.PI*radius*radius;
        }
    }
}