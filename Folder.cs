using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace T1_SemesterTest
{
    public class Folder : Thing
    {
        private List<Thing> _contents;

        public Folder(string name) : base(name)
        {
            _contents = new List<Thing>();
        }

        public void Add(Thing addthing)
        {
            _contents.Add(addthing);
        }

        public override int Size()
        {
            int totalSize = 0;
            foreach (var thing in _contents)
            {
                totalSize += thing.Size();
            }
            return totalSize;
        }

        public override void Print(string indent = "")
        {
            if (_contents.Count != 0)
            {
                Console.WriteLine($"{indent}The folder '{_name}' contains {Size()} bytes total:");
            }
            if (_contents.Count == 0)
            {
                Console.WriteLine($"{indent}The folder '{_name}' is empty!");
            }
            foreach (Thing thing in _contents)
            {
                thing.Print(indent + "  ");
            }
        }
    }
}