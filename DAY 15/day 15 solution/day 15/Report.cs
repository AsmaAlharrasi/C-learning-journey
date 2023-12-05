using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_15
{
    internal class Report
    {
        public void TotalSalesMoreThan60K(Employees[] emps) 
        {
            Console.WriteLine("1)Report For Employees Total Sales More Than 60k:");
            //Console.WriteLine("-----------------------------------------------=");
            foreach (Employees emp in emps) 
            {
                if (emp.TotalSales >= 60000)
                {
                    Console.WriteLine($" {emp.Id} => {emp.Name} => {emp.Gender} => {emp.TotalSales}");
                }
            }
            Console.WriteLine("\n");
        }

        public void TotalSalesBetween30kAnd60K(Employees[] emps)
        {
            Console.WriteLine("2)Report For Employees Total Sales Between 30k And 60k:");
            //Console.WriteLine("-----------------------------------------------=");
            foreach (Employees emp in emps)
            {
                if (emp.TotalSales < 60000 && emp.TotalSales >= 30000)
                {
                    Console.WriteLine($" {emp.Id} => {emp.Name} => {emp.Gender} => {emp.TotalSales}");
                }
            }
            Console.WriteLine("\n");
        }

        public void TotalSalesLessThan30K(Employees[] emps)
        {
            Console.WriteLine("3)Report For Employees Total Sales Less Than 30k:");
            //Console.WriteLine("-----------------------------------------------=");
            foreach (Employees emp in emps)
            {
                if (emp.TotalSales < 30000)
                {
                    Console.WriteLine($" {emp.Id} => {emp.Name} => {emp.Gender} => {emp.TotalSales} ");
                }
            }
            Console.WriteLine("\n");
        }

        public delegate bool SalesCondition(Employees e); 

        public void EmployeeFiltiration(Employees[] emp, string Title , SalesCondition cond)
        {
            Console.WriteLine(Title);
            //Console.WriteLine("----------------------------------");
            foreach (Employees e in emp )
            {
                if (cond(e))
                {
                    Console.WriteLine($" {e.Id} => {e.Name} => {e.Gender} => {e.TotalSales} ");

                }
            }
            Console.WriteLine("\n");
        }

    }
}
