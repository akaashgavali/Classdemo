using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create class studentAuto generate the rollno Accept name & 3 subject marks from constructor Use calculate method to calculate total & percentage
//Display details using ToString()

namespace Classdemo
{
    public class Homeworkstudent
    {
        private string name;
        private int math;
        private int english;
        private int marathi;
        private int total;
        private double percentage;

        public int rollno { get; set; }

        public Homeworkstudent(string name,int math,int english,int marathi)
        {
            this.name = name;
            this.math = math;
            this.english = english;
            this.marathi = marathi;
        }
        public void Calculatemark()
        {
            total = math + english + marathi;
            percentage = total / 3;
        }
        public override string ToString()
        {
            return $" Name :{name}  rollnno {rollno}  total marks {total}  and percentage {percentage}";
        }
    }
}
