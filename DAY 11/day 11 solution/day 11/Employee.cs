namespace day_11
{
    internal class Employee
    {
        private int id;
        private string name;
        private int age;
        private string address;
        private string email;


        public Employee (int id, string name, int age, string email, string address)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
            this.email = email;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
