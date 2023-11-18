namespace day_3
{
     class Program
     {
        static void Main()
        {

            #region casting double

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

            #endregion

            #region casting object

            // object

            Object obj1 = new object();
            Object obj2 = new object();
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
            Console.WriteLine("aaaaaaaaa");
            obj2 = obj1;
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            #endregion

            #region Reference Type Comparison

            string s1 = "A";
            string s2 = s1;
            s1 = "B";

            ////Memory adress in hexadecimal
            Console.WriteLine("s1 value : " + s1);
            Console.WriteLine("s1 place : " + s1.GetHashCode());

            Console.WriteLine("s2 value : " + s2);
            Console.WriteLine("s2 place : " + s2.GetHashCode());

            #endregion

            #region postfix and prefix

            //postfix
            int z = 1;
            Console.WriteLine(z++); //print 1
            Console.WriteLine(z); //print 2


            //prefix
            int a = 1;
            Console.WriteLine(++a); //print 2
            Console.WriteLine(a); //print 2

            #endregion

            #region $ String text
            Console.WriteLine($"s1 value :  {s1}"); /* we put $ in the beiging to write value inside the string text 
                                                      * but we should write the value inside curly prases {} */
            #endregion

        }

     }

}