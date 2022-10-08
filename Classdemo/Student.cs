using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classdemo
{
    internal class Student
    {
        private int rollno;
        private string name;
        double percentage;

        public void add(int rollno, string name, double percentage)
        {
            this.rollno = rollno;
            this.name = name;
            this.percentage = percentage;
        }
        public string Print()
        {
            return $"Student:{rollno}/{name}/{percentage}";
        }
    }
}