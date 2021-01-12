using System;
using System.Collections.Generic;
using System.Text;

using Utility_vehicle = Automotive.Vehicle.Jeep;

namespace Automotive
{
    namespace Vehicle
    {
        namespace Jeep
        {
            class Category
            {
                string _category;
                public Category()
                {
                    _category = "Multi Utility Vehicle";
                }
                public void display()
                {
                    Console.WriteLine("Jeep category: " + _category);
                }
            }
            class Automobile
            {
                static void Main(string[] args)
                {
                    Category objCat = new Category();
                    Utility_vehicle::Category objCategory = new Utility_vehicle::Category();
                    objCategory.display();
                        
                }
            }
        }
    }
}
