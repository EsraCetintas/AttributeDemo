using System;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person()
            {
                Id = "1",Name = "Esra"
            };

            if(Control.Check(person1))
                Console.WriteLine("true");
            else
                Console.WriteLine("false"); 
        }
    }
}
