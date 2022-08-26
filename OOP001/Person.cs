namespace OOP001
{
    internal class Person
    {
        private string? name;
        private DateTime? dob;
        private string? email;
        private string? password;


        public string? Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Prøv igen...");
                    name = null;
                }
                else name = value;
            }

        }
        

        public DateTime? DoB 
        {
            get { return dob; }
            set
            {
                if (value < DateTime.Now) dob = value;
                else
                {
                    Console.WriteLine("Fødselsdato ikke godkendt, skal være før i dag.");
                    dob = null;
                }
            }
        }


        public int Age
        {
            get
            {
                if (DoB != null)
                {
                    DateTime today = DateTime.Today;
                    int age = today.Year - ((DateTime)DoB).Year;
                    if (today < new DateTime(today.Year, ((DateTime)DoB).Month, ((DateTime)DoB).Day)) age--;
                    return age;
                }
                else return 0;

            }
        }

        public string? Email
        {
            get { return email; }
            set
            {

                if (value.Contains(".") && value.Contains("@"))
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine("Husk at inkludere (@) og (.) i din email..");
                    value = null;
                }
            
            }
        }
        public string? Password
        {
            get { return password; }
            set
            {
                if (value.Length > 6 && value.Any(char.IsUpper) && value.Any(char.IsLower) && value.Any(char.IsDigit) && value.Contains(" ") == false)
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Password skal være længere end 6 karakterer og indeholde store og små bogstaver samt tal");
                    value = null;
                }
            }
        }
    }
}
