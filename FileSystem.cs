using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_SemesterTest
{
    public class FileSystem
    {
        private List<Thing> _contents;

        public FileSystem()
        {
            _contents = new List<Thing>();
        }

        public void Add(Thing addthing)
        {
            _contents.Add(addthing);
        }

        public void PrintContents()
        {
            Console.WriteLine("This file system contains:");
            foreach (var thing in _contents)
            {
                thing.Print("  ");
            }
        }
    }
}
