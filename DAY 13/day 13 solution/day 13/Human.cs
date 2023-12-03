using day_13;

namespace day_12.Human_Class
{
    internal class Human : Creature , IMove 
    {
        public int id;
        public string name;
        public int age;
        public bool HasJob;
        public bool IsMarried;

        public void Move()
        { 
            Console.WriteLine(" I am moving");
        }
        public void Eat()
        {
            Console.WriteLine("I am eating");
        }
        public void Sleep()
        {
            Console.WriteLine(" I am sleeping");

        }
        public Human()
        {

        }

        public Human(int id, string name, int age, bool HasJob, bool IsMarried)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.HasJob = HasJob;
            this.IsMarried = IsMarried;
        }

        public void Describe()
        {
            Console.WriteLine($" ID: {id} \nNAME: {name} \nAGE: {age}" +
                $" \nHAS JOB(YES/NO): {HasJob} \nIS MARRIED((YES/NO): {IsMarried}");
        }
        public override string ToString()
        {
            return $"ID: {id} \nNAME: {name} \nAGE: {age}";

        }









    }



}