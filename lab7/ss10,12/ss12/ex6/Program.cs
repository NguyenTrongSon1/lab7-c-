using System;

namespace ex6
{
    public delegate void Display(string msg);
    public class Parent
    {
        event Display Print;
        protected void InvojeMethod()
        {
            Print += new Display(PrintMessage);
            check();
        }
        void check()
        {
            if (Print != null)
            {
                PrintMessage("Welcome to C#");
            }
        }
        void PrintMessage(String msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Child : Parent
    {
        static void Main(string[] args)
        {
            Child objChild = new Child();
            objChild.InvojeMethod();

        }
    }
}
