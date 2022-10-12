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

            //Course c1 = new Course();
            //c1.Add(232, "java", 10000);
            //Console.WriteLine(c1.Print());

            //Constructorcourse c1 = new Constructorcourse(12, "Akash", 1000);
            //Constructorcourse c2 = new Constructorcourse(13, "gavali", 2000);
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);

            //using propert initializer course
            //Propertycourse p1 = new Propertycourse();
            //p1.Id = 121;
            //p1.Name = "java";
            //p1.Fees = 12000;
            //Console.WriteLine(p1.Id + p1.Name + p1.Fees);
            //Console.WriteLine(p1);
            //using object initializer
            //Propertycourse p2 = new Propertycourse { Id = 231, Name = "Dotnet", Fees = 15000 };
            //Console.WriteLine(p2);

            //constructorstudent

            //Constructorsudent s1 = new Constructorsudent(12, "Akash", 76.65);
            //Constructorsudent s2 = new Constructorsudent(13, "gavali", 45.34);
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            //using propert initializer student
            //Propertystudent s1 = new Propertystudent();
            //s1.Rollno = 121;
            //s1.Name = "ram";
            //s1.Percentage = 65.45;
            //Console.WriteLine(s1);
            //using object initializer
            //Propertystudent s2 = new Propertystudent { Rollno = 231, Name = "vijay", Percentage = 75.50 };
            //Console.WriteLine(s2);


            //constructoemployee

            //Constructoremployee e1 = new Constructoremployee(123, "Akash", 35000);
            //Constructoremployee e2 = new Constructoremployee(135, "ram", 44500);
            //Console.WriteLine(e1);
            //Console.WriteLine(e2);

            //// using property initializer student
            // Propertyemployee e1 = new Propertyemployee();
            // e1.Id = 345;
            // e1.Name = "sagar";
            // e1.Salary = 65000;
            // Console.WriteLine(e1);
            // //using object initializer
            // Propertyemployee e2 = new Propertyemployee { Id = 231, Name = "pratik", Salary = 75000 };
            // Console.WriteLine(e2);

            // using property initializer student
            //Autopropstudent a1 = new Autopropstudent();
            //a1.Rollno = 345;
            //a1.Name = "sagar";
            //a1.Percentage = 78.98;
            //Console.WriteLine(a1);
            //using object initializer
            //Autopropstudent a2 = new Autopropstudent { Rollno= 231, Name = "pratik", Percentage = 89.90 };
            //Console.WriteLine(a2);

            
            
                //Staticmethod e1 = new Staticmethod("emp1", 23000);
                //Staticmethod e2 = new Staticmethod("emp2", 24000);
                //Staticmethod e3 = new Staticmethod("emp3", 24000);
                // e1.CalculateSalary();
                // e2.CalculateSalary();
                // e3.CalculateSalary();


                //Console.WriteLine(e1);
                //Console.WriteLine(e2);
                //Console.WriteLine(e3);
                //Console.WriteLine(Staticmethod.TotalCount());

            Homeworkstudent s1 = new Homeworkstudent("Akash", 60, 60, 60);
            s1.rollno = 132;
            s1.Calculatemark();
            Console.WriteLine(s1);
            



        }
    }
}
