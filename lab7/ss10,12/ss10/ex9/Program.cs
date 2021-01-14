using System;

namespace ex9
{
    class ExceptionProperties
    {
        static void Main(string[] args)
        {
            byte numOne = 200;
            byte numTwo = 5;
            byte result = 0;
            try
            {
                result = checked((byte)(numOne * numTwo));
                Console.WriteLine("Result = {0}", result);
            }
            catch(OverflowException objEX)
            {
                Console.WriteLine("Message:{0}", objEX.Message);
                Console.WriteLine("Source: {0}", objEX.Source);
                Console.WriteLine("TargetSite:{0}", objEX.TargetSite);
                Console.WriteLine("StackTrace:{0}", objEX.StackTrace);
            }
            catch (Exception objEX)
            {
                Console.WriteLine("Error: {0}", objEX);
            }
        }
    }
}
