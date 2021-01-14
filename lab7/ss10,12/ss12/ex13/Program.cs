using System;
using System.Collections;

namespace ex13
{
    class StoredCollection
    {
        static void Main(string[] args)
        {
            SortedList objSortList = new SortedList();
            objSortList.Add("John", "Administrtion");
            objSortList.Add("Jack", "Human Resources");
            objSortList.Add("Peter", "Finance");
            objSortList.Add("Joel", "Marketing");
            Console.WriteLine("Original values stored in the sosted list");
            Console.WriteLine("key\t\tvalues");
            for(int i = 0; i < objSortList.Count; i++)
            {
                Console.WriteLine(objSortList.GetKey(i) + "\t\t" + objSortList.GetByIndex(i));
            }
            if (!objSortList.ContainsKey("Jerry"))
            {
                objSortList.Add("Jerry", "Construction");
            }
            objSortList["Peter"] = "Engineering";
            objSortList["Jerry"] = "Information Technology";
            Console.WriteLine();
            Console.WriteLine("Update values stored in hash table");
            Console.WriteLine("key \t\t Values");
            for(int i= 0;i < objSortList.Count; i++)
            {
                Console.WriteLine(objSortList.GetKey(i) + "\t\t" + objSortList.GetByIndex(i));
            }
        }
    }
}
