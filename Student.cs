using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Student : Person
    {
        private int year;
        private double fee;

        public int Year { set; get; }
        public double Fee { set; get; }

        public Student(string studentname, string studentaddress, int studentyear, double studentfee)
            : base(studentname,studentaddress)
        {
        Year=studentyear;
            Fee= studentfee;
        }
        
        public Student():this("not provided","not provided", 0, 0.0) { }


        public override string ToString()
        {
            return ($"\t{Name}.\t{Address}.\t{Year}.\t{Fee}");
        }



    }
}
