using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {     
        static void Main(string[] args)
        {
            
            List<Object> SchoolList = new List<Object> { new Student("Mike", "1234 Notebook Way", ".Net Beast", 2017, 569), new Staff("Allie", "1212 Badass Way.", "University of Michigan", 58000), new Person("Noah", "1235 Long Point Road") };
            
            foreach (Object o in SchoolList)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(o.ToString());
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
    }
}
