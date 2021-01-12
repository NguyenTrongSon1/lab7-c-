using System;

namespace ex4
{
    class Program
    {
        public delegate void Messenger(int value);
        class CompositeDelegate
        {
            static void EvenNumber(int value)
            {
                Console.Write("Even Numbers:");
                for(int i = 2; i <= value; i += 2)
                {
                    Console.Write(i + " ");
                }
            }
            void OddNumbers(int value)
            {
                Console.WriteLine();
                Console.Write("Odd Numbers:");
                for(int i = 1; i <= value; i += 2)
                {
                    Console.Write(i + " ");
                }
            }
            static void Start(int number)
            {
                CompositeDelegate objCompost = new CompositeDelegate();
                Messenger objDisplayOne = new Messenger(EvenNumber);
                Messenger objDisplayTwo = new Messenger(objCompost.OddNumbers);
                Messenger objDisplayComposite = (Messenger)Delegate.Combine(objDisplayOne, objDisplayTwo);
                objDisplayComposite(number);
                Console.WriteLine();
                object obj = objDisplayComposite.Method.ToString();
                if(obj != null)
                {
                    Console.WriteLine("The delegate invokes an instance method:" + obj);
                }
                else
                {
                    Console.WriteLine("The delegate invokes only static methods");
                }

            }
            static void Main(string[] args)
            {
                int value = 0;
                Console.WriteLine("Enter the values till which you want to display even and odd numbers");
                try
                {
                    value = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException objFormat)
                {
                    Console.WriteLine("Error:" + objFormat);
                }
                Start(value);
            }
        }
    }
}
