using System;

namespace ex5
{
    class Program
    {
        public delegate void PrintDetails();
        class TestEvent
        {
            event PrintDetails Print;
            void Show()
            {
                Console.WriteLine("This program ill ustrate how to subsribe object to an event");
                Console.WriteLine("This method will not execute since has not been raised");
            }
            static void Main(string[] args)
            {
                TestEvent objTestEven = new TestEvent();
                objTestEven.Print += new PrintDetails(objTestEven.Show);
                objTestEven.Print();
               
            }
        }
    }
}
