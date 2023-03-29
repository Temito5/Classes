using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_3
{
    internal class Family
    {
        public List<Person> members = new List<Person>();

        public void AddMember(Person person)
        {
            if (person.age >= 30)
            {
                members.Add(person);
            }
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
