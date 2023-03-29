using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person person1 = new Person();
            Person person2 = new Person();
            Person person3=new Person();

            person1.Name = "Gosho";
            person1.Age = 18;

            person2.Name = "Pesho";
            person2.Age = 20;

            person3.Name = "Stamat";
            person3.Age = 43;

            Console.WriteLine($"{person1.Name} -> {person1.Age} age");
            Console.WriteLine($"{person2.Name} -> {person2.Age} age");
            Console.WriteLine($"{person3.Name} -> {person3.Age} age");

        }
    }
}
