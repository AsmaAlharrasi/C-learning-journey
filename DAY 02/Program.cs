namespace day_2
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("hello, world");

            #region String Concatenation 

            //String Concatenation
            string FirstName = "Asma Alharrasi";
            string FullTimeJob = "Trainee at Code Academy";
            int age;
            age = 22;

            Console.WriteLine("my first name is : "  + FirstName  +   "\n" +
                "my age is: " + age );
            Console.WriteLine("my full time job is : " + FullTimeJob );

            //string interpolation
            Console.WriteLine($" My name is {FirstName} and My job is {FullTimeJob} ");

            #endregion

            #region Expression

            int y = 6 + 2; //result ==> the Expression "6+2" evaluates to 8
            string name = "Asma" + "Alharrasi"; //the Expression " "Asma" + "Alharrasi" " evaluates to ==> Asma Alharrasi
            bool x = (2 < 3) && (2 = 3); //the Expression "(2 > 3) && (2 = 3)" evaluates to False

            #endregion

            #region Comparison Operators

            int x = 3;
            int y = 4;

            bool equel = x == y; // result ==> false
            bool notequel = x != y; //result ==> true
            bool greater = x > y; // result ==> false
            bool less = x < y; // result ==> true

            Console.WriteLine(equel);

            #endregion

            #region Logical Operator

            bool a = true;
            bool b = false;

            bool resultAND = a && b; // result ==> false
            bool resultOR = a || b; // result ==> true 
            bool resultNOT = a != b; // result ==> false
            bool resultXOR = a ^ b; // result ==> true

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

        }
    }
    
}
