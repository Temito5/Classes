using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    internal class Family
    {
        public List<Person> members = new List<Person>();

        public void AddMember(Person person)
        {
            members.Add(person);
        }

        public void Print()
        {
           
            foreach (Person member in members)
            {

                Console.WriteLine($"{member.name} {member.age}");
            }
          
        }
    }
}
