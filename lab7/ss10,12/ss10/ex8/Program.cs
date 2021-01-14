using System;

namespace ex8
{
    class student
    {
        string[] _names = { "James", "John", "Alexander" };
        static void Main(string[] args)
        {
            student objStudent = new student();
            try
            {
                objStudent._names[4] = "Michael";
            }
            catch(Exception objException)
            {
                Console.WriteLine("Error: " + objException);
            }
        }
    }
}
