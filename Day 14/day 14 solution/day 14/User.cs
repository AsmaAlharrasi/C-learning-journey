using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_14
{
    internal class User
    {
        public string Name { get; set; }
        public int age { get; set; }
        public int Mony { get; set; }

        public User( string Name , int age , int Mony)
        {
            this.Name = Name;
            this.age = age;
            this.Mony = Mony;
        }

        public static int operator + (User a, User b)
        {
            int sum = a.Mony + b.Mony;
            return sum;
        }

        public static int operator - (User a, User b)
        {
            int result = a.Mony - b.Mony;
            return result;
        }

        public static bool operator == (User a, User b)
        {
            if (a.Mony == b.Mony)
            {
                return true;
            } return false;
        }

        public static bool operator !=(User a, User b)
        {
            if (a.Mony != b.Mony)
            {
                return true;
            }return false;
        }
    }

}
