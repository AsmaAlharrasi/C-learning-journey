using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_12.Human_Class
{
    internal class Students : Human
    {
        public string Qualification;
        public bool IsIntern;
        public int TotalGrades;
        public int StdudingHours;


        public Students(int id, string name, int age, bool HasJob, bool IsMarried, string Qualification, bool IsInternt, int TotalGrades, int StdudingHours) 
            : base(id, name, age, HasJob, IsMarried)
        {
            this.Qualification = Qualification;
            IsIntern = IsInternt;
            this.TotalGrades = TotalGrades;
            this.StdudingHours = StdudingHours;
        }

    }
}
