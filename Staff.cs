using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Staff:Person
    {
        private string school;
        private double pay;

        public string School { set; get; }
        public double Pay { set; get; }

        public  Staff(string stafname,string stafaddress,string stafschool,double stafpay )
            :base(stafname,stafaddress)
        {
            School = stafschool;
            Pay = stafpay;
        }
        public Staff() : this("not provided", "not provided", "not provided", 0.0) { }

        public override string ToString()
        {
            return ($"\t{Name}.\t{Address}.\t{School}.\t{Pay} ");
        }


    }
}
