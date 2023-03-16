using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Father
    {
        public void Eyecolor() 
        {
            Console.WriteLine("Fathers eyes are blue.");
        }
        public abstract void Surname();
    }
    class Son:Father
    {
        public void Name(string name)
        {            
            Console.WriteLine($"Son's name is {name}.");
        }
        

            public override void Surname()
        {
            Console.WriteLine("Enter surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine($"Their surname is {surname}.");
        }        
    }
}
