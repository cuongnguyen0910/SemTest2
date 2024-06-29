using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_SemesterTest
{
    public abstract class Thing
    {
        protected string _name;

        public Thing(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public abstract int Size();
        public abstract void Print(string indent = "");
    }
}
