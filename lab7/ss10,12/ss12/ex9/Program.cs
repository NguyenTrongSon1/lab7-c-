using System;
using System.Collections;

namespace ex9
{
    class ArryCollection
    {
        static void Main(string[] args)
        {
            ArrayList objArray = new ArrayList();
            objArray.Add("John");
            objArray.Add("James");
            objArray.Add("Peter");
            objArray.RemoveAt(2);
            objArray.Insert(2, "Williams");
            Console.WriteLine("Capacity:" + objArray.Capacity);
            Console.WriteLine("Count:" + objArray.Count);
            Console.WriteLine();
            Console.WriteLine("Element of the ArrayList");
            foreach(string str in objArray)
            {
                Console.WriteLine(str);
            }
        }
    }
}
