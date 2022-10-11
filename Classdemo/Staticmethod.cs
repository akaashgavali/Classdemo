using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classdemo
{
    public class Staticmethod
    {
        private int id;//4
        private string name;//4
        private double basicsalary;
        private double hra;
        private double da;
        private double pf;
        private double netpaid;
        private static int count;
        public Staticmethod(string name, double basicsalary)
        {
            count++;
            this.id = count;
            this.name = name;
            this.basicsalary = basicsalary;
        }
        public void CalculateSalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;
            netpaid = (hra + da + basicsalary) - pf;
        }


        public static string TotalCount()
        {
            return $"Total count is {count}";
        }
        
        public override string ToString()
        {
            return $"Id :{id} Name :{name} Salary {basicsalary} total paid{netpaid}";
        }
    }

}

