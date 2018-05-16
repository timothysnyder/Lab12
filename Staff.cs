using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{

    class Staff : Person
    {

        private string school;
        private double pay;
 
        public string School { get => school; set => school = value; }
        public double Pay { get => pay; set => pay = value; }

        public Staff()
        {
            Pay = 85.00;
        }
        public Staff(string n, string a, string s, double p) : base(n, a)
        {
            School = s;
            Pay = p;
        }
   
        public override string ToString()
        {
            return $"Staff: {Name} \nAddress: {Addess} \nSchool: {School} \nPay: {Pay}\n";
        }
    

    }
}
