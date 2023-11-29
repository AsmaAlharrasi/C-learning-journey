namespace day_11
{
   internal class Human
   { 
        private int id;
        public string name;
        public int age;
        public string address;
        private string email;


        public Human(int id ,string name, int age, string email,  string address)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
            this.email = email;
        }


        #region getter & setter
        public int getId()
        { 
            return this.id;
        }
        public string getemail()
        {
            return this.email;
        }
        public void setemail(string email)
        {
            this.email = email;
        }
        #endregion

        //public string greetingbyname() => $" Hello from {this.name}" +
        //    $" my email address is :{this.email} I am {this.age} years old I live in {this.address} "; 
   }













}