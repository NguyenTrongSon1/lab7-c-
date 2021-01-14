using System;

namespace ex12
{
    class Employee
    {
        private string _empName;
        private int _empID;
        public Employee()
        {
            _empName = "David";
            _empID = 101;
        }
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            Employee objEmp = objEmployee;
            objEmployee = null;
            try
            {
                Console.WriteLine("Employee Name:" + objEmployee._empName);
                Console.WriteLine("Employee ID: " + objEmployee._empID);
            }
            catch(NullReferenceException objNull)
            {
                Console.WriteLine("Errpr:" + objNull);
            }
            catch(Exception objEx)
            {
                Console.WriteLine("Error:" + objEx);
            }
    }
}
