using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP001
{
    internal class StartUp
    {
        public StartUp()
        {
            Person person = new Person();
            GetName(person);
            GetDoB(person);
            GetEmail(person);
            GetPassword(person);
            Console.WriteLine("Hej " + person.Name);
            Console.WriteLine($"Du er {person.Age} år og her er datoen for din foedsel: {person.DoB}");
            Console.WriteLine("Dette er din email: " + person.Email);
            Console.WriteLine("Dit Password er: " + person.Password);


        }
        private void GetName(Person person)
        {
            do
            {
                Console.Write("Hvad er navnet på personen: ");
                person.Name = Console.ReadLine();
            } 
            while (person.Name == null);
        }

        private void GetDoB(Person person)
        {
                do
                {
                    Console.Write("Indtast fødselsdato (dd/mm/åååå: ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime dt)) person.DoB = dt;
                    else person.DoB = null;
                }
                while (person.DoB == null);
        }

        private void GetEmail(Person person)
        {
            do
            {
                Console.Write("Opret Email: ");
                person.Email = Console.ReadLine();
            }
            while (person.Email == null);
        }

        private void GetPassword(Person person)
        {
            do
            {
                Console.Write("Opret Password: ");
                person.Password = Console.ReadLine();
            }
            while (person.Password == null);
        }
    }
}
