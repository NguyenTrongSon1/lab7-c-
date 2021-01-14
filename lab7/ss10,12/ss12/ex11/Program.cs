using System;
using System.Collections;

namespace ex11
{
    class HashCollection
    {
        static void Main(string[] args)
        {
            Hashtable objTable = new Hashtable();
            objTable.Add(001, "John");
            objTable.Add(002, "Peter");
            objTable.Add(003, "James");
            objTable.Add(004, "Joe");
            Console.WriteLine("Number of elements in hash table:" + objTable.Count);
            ICollection objCollection = objTable.Keys;
            Console.WriteLine("Original values stored in hash table are: ");
            foreach(int i in objCollection)
            {
                Console.WriteLine(i + ":" + objTable[i]);
            }
            if (objTable.ContainsKey(002))
            {
                objTable[002] = "Patrick";
            }
            Console.WriteLine("Values stored in the hash table after remving values");
            foreach(int i in objCollection)
            {
                Console.WriteLine(i + ":" + objTable[i]);
            }
        }
    }
}
