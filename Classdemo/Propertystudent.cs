using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classdemo
{
    public class Propertystudent
    {
        private int rollno;
        private string name;
        private double percentage;

        public int Rollno
        {
            get { return rollno; }
            set { rollno = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }
        public override string ToString()
        {
            return $"{rollno} {name} {percentage}";
        }
    }
}
