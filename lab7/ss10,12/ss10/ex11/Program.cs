using System;

namespace ex11
{
    class InvalidCastError
    {
        static void Main(string[] args)
        {
            try
            {
                float numOne = 3.14F;
                object obj = numOne;
                int result = (int)obj;
                Console.WriteLine("Value of numOne = {0}", result);
            }
            catch(InvalidCastException objEX)
            {
                Console.WriteLine("Message:{0}", objEX.Message);
                Console.WriteLine("Error:{0}", objEX);
            }
            catch (Exception objEX)
            {
                Console.WriteLine("Error:{0}", objEX);
            }
        }
    }
}
