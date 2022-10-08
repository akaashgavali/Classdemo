using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classdemo
{
    internal class Employee
    {
        private int id;
        private string name;
        private int salary;
        public void Add(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public string Print()
        {
            return $"Employee:{id}/{name}/{salary}";
        }
    }
}
