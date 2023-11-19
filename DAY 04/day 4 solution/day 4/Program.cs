namespace day_4
{
    class Program
    {
        static void Main()
        {

            #region Array
            ///* we put a variable inside the array
            // * to make it flexibale for the user to 
            // * enter any number of value */

            //int n;
            //n = Convert.ToInt32(Console.ReadLine()); 
            //int[] arr1 = new int[n];
            //Console.WriteLine("enter a value of yout array:" + n);

            ////Multi Dimensinol Array

            //int[,] Grades = new int[2,2]; // 2 raws , 2 columns 
            //Grades[0, 0] = 1;
            //Grades[0, 1] = 2;
            //Grades[1, 0] = 1;
            //Grades[1, 1] = 3;

            ////Jagged Array

            //int[][] Employee = new int[2][];
            //Employee[0] = new int[2] { 2 , 4 }; //araay size 2
            //Employee[1] = new int[3] { 1, 7, 4 }; //array size 3
            #endregion

            #region Code Practist Array

            //Practic Code 

            //// 1- One Dimentsional Araay:
            //string[] names = new string[3];
            //names[0] = "Asma";
            //names[1] = "Sara";
            //names[2] = "Ahmed";
            //Console.WriteLine("your name is : " + names[2]);

            //// 2- Multi Dimentsional Array:
            //int[,] age = new int[2, 4]; // 2 raws , 2 columns 
            //age[0, 0] = 22;
            //age[0, 1] = 43;
            //age[0, 2] = 18;
            //age[0, 3] = 30;
            //age[1, 0] = 12;
            //age[1, 1] = 22;
            //age[1, 2] = 51;
            //age[1, 3] = 29;
            //Console.WriteLine("age is:" + age[0, 3]);

            ////3-Jagged Array:

            //string[][] colors = new string[3][];
            //colors[0] = new string[1] { "red" };
            //colors[1] = new string[4] { "blue", "white", "orange", "black" };
            //colors[2] = new string[3] { "gray", " orange", "green" };
            //Console.WriteLine("color: " + colors[1][2]); /* acsses data :
            //                                             * [1] ==> index of main array 
            //                                             * [2]==> indext of array collection 
            //                                             * acsess the second elemnt in the secend array */

            #endregion

            #region If Statment

            ////If Statments:

            //Console.WriteLine("hello please enter student grade:");
            //int value = Convert.ToInt32(Console.ReadLine());
            //if (value >= 80)
            //{
            //    Console.WriteLine("Sucssed");
            //}
            //else if (value >= 60)
            //{
            //    Console.WriteLine("failed");
            //}
            //else
            //{
            //    Console.WriteLine("invalid");
            //}

            #endregion

            #region HW 1 solution

            ////HW 1
            //string[] menu = { "Latte", "Capp", "Amre" };
            //double[] price = { 3.50, 2.50, 1.50 };
            //string[] size = { "small", "medium", "larg" };

            //Console.WriteLine($"1.{menu[0]} -- 3.50");
            //Console.WriteLine($"1.{menu[1]} -- 2.50");
            //Console.WriteLine($"1.{menu[2]} -- 1.50");
            //Console.WriteLine("please select the desierd drink from (1-3): ");
            //int value = Convert.ToInt32( Console.ReadLine() );

            //string Drink;
            //double prices;
            //string size;

            #endregion


            //Switch:




        }
    }
}