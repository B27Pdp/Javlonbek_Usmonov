namespace OOP.Lesson_Generic.Lessontasks
{
    class User
    {
        string name = "";
        string email = "";
        string phone = "";
        public string this[string propname]
        {
            get
            {
                switch (propname)
                {
                    case "name": return name;
                    case "email": return email;
                    case "phone": return phone;
                    default: throw new Exception("Bunaqa case mavjud emas!!!");
                }
            }
            set
            {
                switch (propname)
                {
                    case "name":
                        name = value;
                        break;
                    case "email":
                        email = value;
                        break;
                    case "phone":
                        phone = value;
                        break;
                }
            }
        }

        public User(string name, string email, string phone)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
        }
    }
}
