using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Person
    {
        protected string name;
        protected string address;

        public string Name { set; get; }
        public string Address { set; get; }

        public Person(string personname,string personaddress)
        {
            Name = personname;
            Address = personaddress;
        }

        public Person():this("not provided","not provided") { }
        public override string ToString()
        {
            return ($"\t{Name}. \t{Address}");
        }

    }
}
