using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace ex7
{
    class Employee : DictionaryBase
    {
        public void Add(int id,string name)
        {
            Dictionary.Add(id, name);
        }
        public void remove(int id)
        {
            Console.WriteLine("You are going to deleted record containing ID:" + id);
            Dictionary.Remove(id);
        }
        public void GetDetails()
        {
            IDictionaryEnumerator objEnumerate = Dictionary.GetEnumerator();
            while (objEnumerate.MoveNext())
            {
                Console.WriteLine(objEnumerate.Key.ToString() + "\t\t" + objEnumerate.Value);
            }
        }
        static void Main(string[] args)
        {
            Employee objEmloyee = new Employee();
            objEmloyee.Add(102, "John");
            objEmloyee.Add(105, "James");
            objEmloyee.Add(106, "Peter");
            Console.WriteLine("Original values stored in Dictionary");
            objEmloyee.GetDetails();
            objEmloyee.OnRemove(106);
            Console.WriteLine("Modified values stored in Dictionary");
            objEmloyee.GetDetails();
        }
    }
}
