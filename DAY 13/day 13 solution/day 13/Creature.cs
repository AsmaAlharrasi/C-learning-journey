using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_13
{
    interface IMove
    {
        void Move();
        void Eat();
        void Sleep();

    } 
    internal class Creature
    {
        string value;
    }
}
