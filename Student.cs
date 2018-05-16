using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public string Program { get => program; set => program = value; }
        public int Year { get => year; set => year = value; }
        public double Fee { get => fee; set => fee = value; }

        public Student()
        {
            Year = 2018;
            Fee = 1000;
        }
        public Student(string n, string a, string p, int y, double f) : base(n, a)
        {
            Program = p;
            Year = y;
            Fee = f;
        }

        public override string ToString()
        {
            return $"\tStudent: {Name} \n\tAddress: {Addess} \n\tProgram: {Program} \n\tYear: {Year} \n\tFee: {fee}\n\t";
        }


    }
}
