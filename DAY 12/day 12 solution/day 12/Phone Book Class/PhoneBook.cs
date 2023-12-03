using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_12.Phone_Book_Class
{
    internal class PhoneBook
    {
        public static int cnt;
        string[] Name;
        long[] Number;
        int Size;

        public PhoneBook(int Size)
        {
            this.Name = new string[Size];
            this.Number = new long[Size];
            this.Size = Size;
        }

        public int GetSize()
        {
            return this.Size;
        }

        public void AddPerson( int order , string name , long number)
        {
            this.Name[cnt] = name;
            this.Number[cnt] = number;
            cnt += 1;
        }

        public long this[string name]
        {
            get
            {
                for (int i = 0; i < this.Size; i++)
                {
                    if (this.Name[i] == name)
                        return this.Number[i];
                }
                return 0;
            }
            set
            {
                this.Name[cnt] = name;
                this.Number[cnt] = value;
                cnt += 1;

            }
        }

        public void GetAll()
        {
            for (int i = 0; i < Size; i++)
            { 
                if (this.Name[i] != null)
                Console.WriteLine($"({i+1} Name: {this.Name[i]}) ------ ( Number: {this.Number[i]})");
            }
        }

        public long GetNumber (string name) 
        {
            for (int i = 0; i < this.Size; i++)
            {
                if (this.Name[i] == name)
                    return this.Number[i];
            } return -1;
        }

        public string GetName(long number)
        {
            for (int i = 0; i < this.Size; i++)
            {
                if (this.Number[i] == number)
                    return this.Name[i];
            }
            return "Try Again";
        }
    }
}
