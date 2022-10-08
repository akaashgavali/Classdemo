using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classdemo
{
    internal class Course
    {
        private int id;
        private string name;
        private int fees;

        public void Add(int id, string name, int fees)
        {
            this.id = id;
            this.name = name;
            this.fees = fees;
        }
        public string Print()
        {
            return $"product:{id}/{name}/{fees}";
        }
    }
}
