namespace day_2
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("hello, world");

            string FirstName = "Asma Alharrasi";
            string FullTimeJob = "Trainee at Code Academy";
            int age;
            
            age = 22;
            Console.WriteLine("my first name is : "  + FirstName  +   "\n" +
                "my age is: " + age );
            Console.WriteLine("my full time job is : " + FullTimeJob );


            // double, decimel, float

            double money = 4.5;
            float salary = 34.98f; //casting from double to float
            decimal ayment = 120.99m; //casting fromb double to decimal


            //casting implicit

            int number_of_days = 90;
            long ssn = number_of_days; //casting from int to long
            Console.WriteLine(ssn);


            //casting explicit

            double payment = 150.500;
            int real_payment = (int)payment; //casting from double to int , int x = (int)y ,long x = (long) y
            Console.WriteLine(real_payment);


            // object

            Object obj1 = new object();
            Object obj2 = new object();
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
            Console.WriteLine("aaaaaaaaa");
            obj2 = obj1;
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

        }
    }
    
}
//class student
//{
//    static void Main()
//    {
//      string FirstName ="Asma Alharrasi"

//    }
//}