using System;

namespace ex3
{
    public delegate void Maths(int valOne, int valTwo);
    class MathsDemo
    {
        static void Addition(int valOne, int valTwo)
        {
            
            int result = valOne + valTwo;
            Console.WriteLine("Addition: " + valOne + "+" + valTwo + "=" + result);
        }
        static void Subtraction(int valOne, int valTwo)
        {
            int result = valOne = valTwo;
            Console.WriteLine("Subtraction:" + valOne + "-" + valTwo + "=" + result);
        }
        static void Multilication(int valOne, int valTwo)
        {
            int result = valOne * valTwo;
            Console.WriteLine("MUltilication:" + valOne + "*" + valTwo + "=" + result);
        }
        static void Division(int valOne, int valTwo)
        {
            int result = valOne / valTwo;
            Console.WriteLine("Division:" + valOne + "/" + valTwo + "=" + result);
        }
        static void Main(string[] args)
        {
           
            Maths objMaths = new Maths(Addition);
            objMaths += new Maths(Subtraction);
            objMaths += new Maths(Multilication);
            objMaths += new Maths(Division);
            //if (objMaths != null)
            //{
            //    objMaths(20, 10);
            //}

        }
    }
}