using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Type consoleType = typeof(Console);
            foreach (var member in consoleType.GetMembers())
            {
                if (member is MethodInfo)
                {
                    Console.WriteLine(member);
                }
            }
            Console.WriteLine();

            Student student = new Student
            {
                Id = 0,
                FullName = "Vasya Pechkin",
                Group = "ASD5",
                BirthDay = DateTime.Parse("12.03.1999"),
                city = "Nur-Sultan",
                country = "Nur-Sultan-Land"
            };

            Type studentType = typeof(Student);
            foreach (var property in studentType.GetProperties())
            {
                Console.WriteLine($"{property} -> {property.GetValue(student)}");
            }
            Console.Read();
        }
    }
}
