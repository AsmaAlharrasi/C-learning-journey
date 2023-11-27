namespace day_9
{
    internal class Program

    {
        static decimal CalculateSalary( int loggedhours , int wages)
        {
            int totalsalary = loggedhours * wages;
            decimal taxcalculate = totalsalary * 0.3m;
            return totalsalary - taxcalculate;
        }
        static void Main()
        {
            Employee emp = new Employee("Asma","Alharrasi",1234,22);


            Console.Write("Hello To Our SYSTEM!!!");

            Console.Write( "\nEnter your First Name:");
            emp.FName = Console.ReadLine();

            Console.Write("Enter your Lirst Name:");
            emp.LName = Console.ReadLine();

            Console.Write("Enter your Age:");
            emp.age = int.Parse(Console.ReadLine());

            Console.Write("Enter your ID:");
            emp.id = int.Parse(Console.ReadLine());

            Console.Write("Enter Wages (price per hour):");
            int wages = int.Parse(Console.ReadLine());

            Console.Write("Enter logged hours:");
            int loggedhours = int.Parse(Console.ReadLine());

            emp.salary = CalculateSalary(loggedhours, wages);


            Console.WriteLine("-------------------------------------");

            Console.WriteLine($"Your Full Name is: {emp.FName} {emp.LName} \nYoure Age is: {emp.age}  \nYour ID Numbers: {emp.id} " +
                $" \nYour Salary is:{emp.salary} ");
        }
    }
}
