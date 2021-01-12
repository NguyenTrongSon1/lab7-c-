using System;

namespace ex2
{
    class Program
    {
        public class SpareParts
        {
            string _spareName = "gear box";
           
            public void display()
            {
                Console.WriteLine("Spare Part name:" + _spareName);
            }
        }
        public class category
        {
            string _category;
            public category()
            {
                _category = "Multi Ultity Vehicle";
            }
            public void display()
            {
                Console.WriteLine("Category: " + _category);
            }
        }
        class Toyota
        {
            static void Main(string[] args)
            {
                category objcate = new category();
                SpareParts objspare = new SpareParts();
                objcate.display();
                objspare.display();
                
            }
        }
    }
}
