using day_12.Human_Class;

namespace day_13
{
    internal class Program
    {
        static void Main()
        {
            Employees emp = new Employees(1,"Asma",22,true,false,"trainee","computer sience",20,23);
            Console.WriteLine(emp.ToString());
        }
    }
}
