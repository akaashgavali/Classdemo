using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classdemo
{
    internal class product
    {
        private int id;
        private string name;
        private int price;

        public void Add(int id,string name,int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public string Print()
        {
            return $"product:{id}/{name}/{price}";
        }
    }
}
