using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student();
            //s1.add(121, "Akash", 75.7);
            //Console.WriteLine(s1.Print());

            //Employee emp1 = new Employee();
            //emp1.Add(111, "akash", 35000);
            //Console.WriteLine(emp1.Print());

            //    product p1 = new product();
            //    p1.Add(3214, "pen", 10);
            //    Console.WriteLine(p1.Print());
            Course c1 = new Course();
                c1.Add(232, "java", 10000);
                Console.WriteLine(c1.Print());


        }
    }
}
