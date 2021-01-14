using System;
using System.Collections;
using System.Collections.Generic;


namespace ex8
{
    class Student : IEnumerable
    {
        LinkedList<string> objList = new LinkedList<string>();
        public void StudentDetails()
        {
            objList.AddFirst("James");
            objList.AddFirst("John");
            objList.AddFirst("Patrick");
            objList.AddFirst("Peter");
            objList.AddFirst("James");
            Console.WriteLine("Number of element stored in the list" + objList.Count);
        }
        public void Display(string name)
        {
            LinkedListNode<string> objNode;
            int count = 0;
            for(objNode = objList.First;objNode !=null;objNode = objNode.Next)
            {
                if (objNode.Value.Equals(name))
                {
                    count++;
                }
            }
            Console.WriteLine("The value " + name + "appears" + count + "time in the list");
        }
        public IEnumerator GetEnumerator()
        {
            return objList.GetEnumerator();
        }
        static void Main(string[] args)
        {
            Student objstudent = new Student();
            objstudent.StudentDetails();
            foreach(string str in objstudent)
            {
                Console.WriteLine(str);
            }
            objstudent.Display("James");
        }
    }
}
