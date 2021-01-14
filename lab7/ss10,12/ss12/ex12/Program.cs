using System;
using System.Collections;

namespace ex12
{
    class Author
    {
        static void Main(string[] args)
        {
            Hashtable objAuthor = new Hashtable();
            objAuthor.Add("AU01", "John");
            objAuthor.Add("AU04", "Mary");
            objAuthor.Add("AU09", "William");
            objAuthor.Add("AU11", "Rodrick");
            Console.WriteLine("Read-only:" + objAuthor.IsReadOnly);
            Console.WriteLine("Count:" + objAuthor.Count);
            IDictionaryEnumerator objClooection = objAuthor.GetEnumerator();
            Console.WriteLine("List of Author:\n");
            Console.WriteLine("Author ID\tName");
            while (objClooection.MoveNext())
            {
                Console.WriteLine(objClooection.Key + "\t\t" + objClooection.Value);
            }
            if (objAuthor.Contains("AU01"))
            {
                Console.WriteLine("\nList contains author with id AU01");
            }
            else
            {
                Console.WriteLine("\nList dose not contain author with id AU01");
            }

        }
    }
}
