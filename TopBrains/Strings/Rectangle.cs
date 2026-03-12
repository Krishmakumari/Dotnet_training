namespace Strings
{
    
    public class Rectangle:Shape,IArea
    {
        private double w;
        private double h;

        public Rectangle(double w,double h)
        {
            this.w=w;
            this.h=h;
        }

        public double Calculatearea()
        {
            return w*h;
        }
    }
}