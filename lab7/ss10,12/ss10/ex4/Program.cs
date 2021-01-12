using IO = System.Console;
using Emp = Bank.Account.EmployeeDetails;

namespace Bank.Account.EmployeeDetails
{
    public class Employees
    {
        public string EmpName;
    }
}
class AlliasExample
{
    static void Main(string[] args)
    {
        Emp.Employees objEMp = new Emp.Employees();
        objEMp.EmpName = "Peter";
        IO.WriteLine("Employee Name: " + objEMp.EmpName);
    }
}

