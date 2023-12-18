using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemoCSharp_43
{
    public class Classroom
    {
        //Properties can be of type List or Array
        public List<Person> OurClass { get; set; } = new List<Person>();

        //Method in class (non static)
        public void GetDetails()
        {
            //Looping through every person in our List property called "OurClass"
            foreach(var person in OurClass)
            {
                //Calling a method from Person class using the variable "person"
                person.Greet();
            }
        }
    }
}
