namespace day_6
{
    class Program
    {
        #region Function Decliration
        //static DataType FunctionName(Arguments or Parameters)
        //{
        //    logic 
        //    return something from the same DataType
        //} //if we identify the data type we should return the value

        //static void FunctionName(Arguments or Parameters)
        //{
        //    logic
        //    Console.WriteLine();
        //}// if we write void we does not return a value 
        #endregion

        #region function 1
        //static void PrintLine( string Pattern ,int Length , bool flag)
        //{
        //    for (int i = 0; i < Length; i++) ;

        //    if (flag == true)
        //    {
        //        Console.WriteLine(Pattern, Length);
        //    }
        //    else
        //    {
        //        Console.WriteLine(Pattern);
        //    }
        //}

        //static void Main() // Main() ==> Startup function
        //{

        //    PrintLine("---",  15 , true );


        //}
        #endregion

        #region Function 2

        //static void swap (int x,int y)
        //{
        //    System.Console.WriteLine ($"original value {x} , {y}");
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //    Console.WriteLine($"swapping value {x} , {y}");
        //}

        //static void Main()
        //{
        //    int a = 4;
        //    int b = 8;
        //    swap( a, b);
        //    Console.WriteLine($"A value is {a} , {b}");

        //}

        #endregion

        #region Function 3

        static void swap ( ref string x, ref string y)
        {
            Console.WriteLine ($"My full name: {x} {y}");
            string temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"My full name reverse : {x} {y}");

        }

        static void Main()
        {
            string firstname = "Asma";
            string lastname = "Alharrasi";
            swap( ref firstname,  ref lastname);
            Console.WriteLine("------------------------");
            Console.WriteLine($"First Name : {firstname} , Last Name: {lastname}" );
        }
        #endregion



    }
}
