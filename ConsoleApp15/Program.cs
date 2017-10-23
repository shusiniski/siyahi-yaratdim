using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>
            {
                new Student(1, "Kamran"),
                new Student(2, "Mehemmed"),
                new Student(3, "Seymur"),
            };

            foreach (var item in Students)
            {
                Console.WriteLine(item.Id +"."+ item.Name);
            }
        }

        class Student
        {
            public int Id;
            public string Name;

            public Student(int _id,string _name)
            {
                Id = _id;
                Name = _name;
            }

        }
    }
}
