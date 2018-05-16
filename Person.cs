using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Person 
    {
        
        private string name;
        private string addess;
        
        public string Name { get => name; set => name = value; }
        public string Addess { get => addess; set => addess = value; }

        public Person()
        {
            Addess = "22742 Olmstead St.";
        }
        public Person(string n, string a)
        {
            Name = n;
            Addess = a;
        }
              
        public override string ToString()
        {
            return $"\tPerson: {Name} \n\tAddress: {Addess} \n\t";
        }     

    }
}
