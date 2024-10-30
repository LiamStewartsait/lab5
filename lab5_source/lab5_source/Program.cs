using System;

namespace lab5_source
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle pos = new Circle(2.0);
            Circle neg = new Circle(-5.0);
            Circle zero = new Circle(0.0);

            pos.ToString();


            try
            {
                pos.setRadius(0);
            }
            catch (InvalidRadiusException e)
            {
                Console.WriteLine(e.Message );
            }

            pos.ToString();



            Console.ReadLine();
        }
    }
}
