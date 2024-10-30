using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_source
{
    internal class Circle
    {
        private double radius;

        public Circle(double radius)
            { this.radius = radius; }

        public double getRadius() {  return radius; }

        public void setRadius(double rad)
        {
            //so probably spent like 15-30 minutes wondering why it wasn't printing the exception message
            //turns out i forgot the = sign so when i was giving zero it passed so it wouldn't throw an exception
            if (rad <= 0)
            {
                throw new InvalidRadiusException(rad);
            }
            else
            {
                this.radius = rad;
            }
            
        }

        private void catchMethod(double radius)
        {

        }


        //doesn't every object already have a ToString meathod?
        //like is this even necessary?
        public void ToString()
        {
            Console.WriteLine("radius = "+radius.ToString());
        }
    }
}
