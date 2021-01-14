using System;

namespace ex2
{
    public delegate double CalculateArea(double val);
    public delegate double CalculateVolume(double val);
    class Cube{
        static double Area(double val)
        {
            return 6 * (val * val);
        }
        static double Volume(double val)
        {
            return (val * val);
        }
        static void Main(string[] args)
        {
            CalculateArea objCalu = new CalculateArea(Area);
            CalculateVolume objVol = new CalculateVolume(Volume);
            Console.WriteLine("Surface Area of Cube:" + objCalu(200.32));
            Console.WriteLine("Volume of Cube: " + objVol(20.56));
        }
    }
}
