namespace day_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("+++++++++++++++++++++++++++++++++++++");

            //Console.Write("Enter your Name:");
            //string name = Console.ReadLine();

            //Console.Write("Enter your Age:");
            //string sage;
            //int.TryParse(Console.ReadLine(), out int age);

            //Console.Write("Enter your E-mail:");
            //string email = Console.ReadLine();

            //Console.Write("Enter your Address:");
            //string address = Console.ReadLine();


            //Console.WriteLine("-----------------------------------------");

            //Human human = new Human( name, email , age , address);
            //Console.WriteLine(human.greetingbyname());

            ////Console.WriteLine($"Your Name is: {human.name} \nYoure Age is: {human.age}  \nYour Address : {human.address} " +
            ////$" \nYour E-mail is:{human.email} \nyour ID number is {human.id} ");

            //Human human1 = new Human("Asma", "gmail.com", 22, "Alrustaq");
            //Console.WriteLine(human1.greetingbyname());

            //_____________________________________________________________

            #region get & set function recall

            Human human2 = new Human(1234,"Asma",22, "Asma@gmail.com", "Alrustaq");
            Console.WriteLine(human2.getId());

            Console.WriteLine(human2.getemail());
            human2.setemail("Sara@gmail.com");
            //human2.setemail(Console.ReadLine());
            Console.WriteLine(human2.getemail());

            #endregion

            #region  get & set for Employee class


            Employee emp = new Employee(1234,"Asma", 22, "gmail.com",  "Alrustaq");

            emp.Id = 4321;
            Console.WriteLine($"Your name is: {emp.Id}");

            emp.Name = "Asma Alharrasi";
            Console.WriteLine($"Your name is: {emp.Name}");

            emp.Age = 23;
            Console.WriteLine($"Your name is: {emp.Age}");

            emp.Email = "Asma Alharrasi@gmail.com";
            Console.WriteLine($"Your name is: {emp.Email}");

            emp.Address = "Oman";
            Console.WriteLine($"Your name is: {emp.Address}");

            #endregion
        }

    }
}