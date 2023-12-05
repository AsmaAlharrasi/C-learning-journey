namespace day_15
{

    internal class Program
    {
        public static void Print<T>(T val)
        {
            Console.WriteLine(typeof(T));
            Console.WriteLine(val);
        }
        static void Main(string[] args)
        {
            #region Delegents

            //Employees[] emps = new Employees[]
            //{
            //    new Employees { Id= 1 , Name="Asma", Gender= 'F', TotalSales= 20000},
            //    new Employees { Id= 2 , Name="Sara", Gender= 'F', TotalSales= 60000},
            //    new Employees { Id= 3 , Name="Ahmed", Gender= 'M', TotalSales= 50000},
            //    new Employees { Id= 4 , Name="Meera", Gender= 'F', TotalSales= 54000},
            //    new Employees { Id= 5 , Name="Suha", Gender= 'F', TotalSales= 10000},
            //    new Employees { Id= 6 , Name="Khalid", Gender= 'M', TotalSales= 87000},
            //    new Employees { Id= 7 , Name="Yuosif", Gender= 'M', TotalSales= 33000},
            //    new Employees { Id= 8 , Name="Reem", Gender= 'F', TotalSales= 93000},
            //    new Employees { Id= 9 , Name="Maha", Gender= 'F', TotalSales= 40000},
            //    new Employees { Id= 10 , Name="Ali",Gender= 'M', TotalSales= 62000}

            //};

            //Report report = new Report();
            //report.TotalSalesMoreThan60K(emps);
            //report.TotalSalesBetween30kAnd60K(emps);
            //report.TotalSalesLessThan30K(emps);

            //Console.WriteLine("---------------------------------------------------\n");

            //Report report1 = new Report();                                    //(emp)=>delegent
            //report1.EmployeeFiltiration(emps, "1)Total Sales More Than 60k:", (emp) => emp.TotalSales >= 60000);
            //report1.EmployeeFiltiration(emps, "2)Total Sales between 60k and 30k:", (emp) => emp.TotalSales < 60000 && emp.TotalSales >= 30000);
            //report1.EmployeeFiltiration(emps, "3)Total Sales Less Than 30k:", (emp) => emp.TotalSales < 30000);

            //Console.ReadKey();
            #endregion

            Print(10); //int
            Print(34.8);//double
            Print('A');//char
            Print("Asma");//string
            Print(4438866666890);//long
            

        }
    }
}
