using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class File : IFileSystemComponent
    {
        private string name;
        private double size;
        public File(string name, double size)
        {
            this.name = name;
            this.size = size;
        }
        public void Display(int depth)
        {
            Console.WriteLine(new String(' ', depth) + $"{name} ({size}kb)");
        }
        public double GetSize()
        {
            return size;
        }
    }
}
