using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraybook
{
    public class Course
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public int Fees { get; set; }
    }

    public class Progrmm
    {
        static void Main(string[] args)
        {
            Course[] c1 = new Course[2]
            {
                new Course { Id = 12, Name = "Java", Duration = "one month", Fees = 5900},
                new Course { Id = 123, Name = "C sharp", Duration = "two month", Fees = 4900 }
            };

            foreach (Course c in c1)
            {
                Console.WriteLine($"{c.Id}{c.Name}{c.Duration}{c.Fees}");
            }

        }
    }

}
