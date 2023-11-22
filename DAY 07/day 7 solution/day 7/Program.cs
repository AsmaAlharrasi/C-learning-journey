namespace day_7
{
    class Program
    {
        #region params function
        
        static int SumArray (int[] array )
        {
            int sum = 0;

            for ( int i = 2; i < array.Length-2; i++)
            {
               sum += array[i];
               
            } return sum;
        }
        static void Main( )
        {

           int[] array = {1,2,3,4,5};
           Console.WriteLine((1,2,3,4,5));

        }

        #endregion





    }


}
