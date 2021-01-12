using System;

namespace ex10
{
    class ExxeptionMethods
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
            catch(Exception objEX)
            {
                Console.WriteLine("Error Descroption: {0}", objEX.ToString());
                objEX.ToString();
                Console.WriteLine("Exception:{0}", objEX.GetType());
            }
        }
    }
}
