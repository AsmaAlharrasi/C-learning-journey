namespace day_3
{
     class Program
     {
        static void Main()
        {

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

            #region Ternary operator

            //Ternary operator 1
            int x = 4;
            string result = (x % 2 == 0) ? " x is even " : " x is odd";
            Console.WriteLine(result);

            //Ternary operator 2
            int y = 10;
            string mod = (y % 3 == 0) ? "divisibale " : " not divisibale";
            Console.WriteLine(mod);
            #endregion

            #region $ String text
            Console.WriteLine($"s1 value :  {s1}"); /* we put $ in the beiging to write value inside the string text 
                                                      * but we should write the value inside curly prases {} */
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

        }

    }

}