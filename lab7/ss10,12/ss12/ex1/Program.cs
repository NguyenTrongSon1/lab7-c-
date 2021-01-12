﻿using System;

namespace ss12
{
    public delegate int Calculation(int numOne, int numTwo);
    class Mathematics
    {
        static int Addition(int numOne,int numTwo)
        {
            return (numOne + numTwo);
        }
        static int Subtraction(int numOne,int numTwo)
        {
            return (numOne - numTwo);
        }
        static void Main(string[] args)
        {
            int valOne = 5;
            int valTwo = 23;
            Calculation objCalculation = new Calculation(Addition);
            Console.WriteLine(valOne + "+" + valTwo + "=" + objCalculation(valOne, valTwo));
        }
    }
}
