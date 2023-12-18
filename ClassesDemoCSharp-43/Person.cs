using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemoCSharp_43
{
    public class Person
    {
        //Fields - a variable inside of a class
        public int money;
        public string clothes;

        //Properties - things that define the class
        public string Name { get; set; } = "Bob";
        public int Age { get; set; }
        public string HairColor { get; set; }

        //Methods in a class (non static)
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }

        //Constructors (methods that build an instance/object from the class)
        //Default constructor
        public Person()
        {
            
        }

        //Custom constructor
        public Person(string name, int age, string hairColor)
        {
            Name = name;
            Age = age;
            HairColor = hairColor;
        }

    }
}
