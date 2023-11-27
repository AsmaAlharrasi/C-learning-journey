﻿namespace day_8
{
    internal class Program
    {
        #region Multiplication Taple
        static void MultiplicationTaple(int n = 1)
        {
            string s = " ";

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Multiplication Taple of {i}");

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j} ");
                }

                Console.WriteLine("____________________________________\n");
            }

        }
        #endregion

        static void Main()
        {

            #region Problem Solving

            int ArrSize, target;
            string s = Console.ReadLine();
            string[] arr = s.Split(" ");
            ArrSize = int.Parse(arr[0]);
            target = int.Parse(arr[1]);

            int[] values = new int[ArrSize];

            //enter value of array
            s = Console.ReadLine();
            //  do space between 
            arr = s.Split(" ");


            //to save it in new int array
            for (int i = 0; i < ArrSize; i++)
            {
                values[i] = int.Parse(arr[i]);
            }

            //valves array
            bool flag = false;

            for (int i = 0, x = i + 1; i < values.Length - 1 && x < values.Length; x++)
            {
                if (values[i] + values[x] == target)
                {
                    Console.WriteLine($"{values[i]} , {values[x]}");
                    flag = true;
                    break;
                }

                //j = i + 1; tsbaq i b khatwa
                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[i] + values[j] == target)
                    {
                        Console.WriteLine($"{i + 1}  {j + 1}");
                        flag = true;
                        break;
                    }

                }

                //if flag = true; then end the loop
                if (flag)
                {
                    break;
                }
                i++;

            }

                #endregion



        }


        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i > +0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i] += 1;
                    return digits;
                }
                digits[i] = 0;
            }
            digits.Append(digits[0] = 1);

            return digits;
        }

    }
}