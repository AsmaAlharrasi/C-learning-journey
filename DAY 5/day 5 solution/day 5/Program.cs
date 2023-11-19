namespace day_5
{
    class Program
    {
        static void Main( )
        {


            #region Boxing and unBoxing

            //Value Type to Reference Type 

            int x = 10;
            string y = x.ToString(); //string is array of chars [ a,s,m,a]
            Console.WriteLine(y[0]);// result ==> 1 as a string

            //Reference Type to Value Type

            //parse()
            string a = "3";
            int z = int.Parse(a);
            Console.WriteLine(a); //result ==> 3 as integer

            //---------------------------------

            string value = "9999a";
            int x;
            bool res = int.tryparse(value, out x);
            string result = int.tryparse(value, out x) ? $"success conversion {x}" : "invalid integer format ";

            if (res)
                console.writeline(x);
            else
                console.writeline("invalid conversion type");

            //tryparse()
            string value = "2468";
            int.TryParse(value, out int x);//result ==> 2468 as integer
            Console.WriteLine(x);

            bool string result = int.TryParse(value, out x) ? $"true {x}" : $"false {x}";//result ==> true or false
            Console.WriteLine(result);

            #endregion

            #region Iteration 

            //anything inside the block stay in the block

            //For Loop

            int[] arr = { 1, 2, 3 };
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine(arr[i]);
            }

            //While

            int[] arr1 = {  4, 5, 6, 7, 8 };
            int ii = 0;
            while (ii <arr1.Length)
            {
                Console.WriteLine(arr1[ii]);
            }

            //Do While ==> run for a step then cheack

            int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8};
            int j = 0;
            while (1==2)
            {
                Console.WriteLine(arr2[0]);
            }
            do//cheack if it is true or false
            {
                Console.WriteLine("Hello");
            }
            while (1 == 2);


            //Foreach 

            int[] arr3 = { 1, 2, 7, 8};
            Console.WriteLine("foreach loop");
            foreach (int jj in arr3)
            {
                Console.WriteLine(jj);
            }






            #endregion

            #region Null & Null Collasion

            //null collasing

            string name = null;
            name = name ?? "NA";

            Console.WriteLine(name);

            string value = null;
            Console.WriteLine(value?.ToLower() ?? "NA");

            /* if there is value print the lower case of it,
             * if there is no value -null- print "NA" */

            #endregion



        }
    }
}
