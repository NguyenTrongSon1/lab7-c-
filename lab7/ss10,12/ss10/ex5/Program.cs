using System;
using System.Collections.Generic;
using System.Text;

namespace Utility_Vehicle
{
    namespace Car
    {
        class category
        {
            string _Category;
            public category()
            {
                _Category = "Luxury Vehicle";
            }
            public void display()
            {
                Console.WriteLine("Car Category: " + _Category);
            }
        }
    }
}
