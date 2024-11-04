using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class Directory : IFileSystemComponent
    {
        private string name;
        private List<IFileSystemComponent> components;
        public Directory(string name)
        {
            this.name = name;
            components = new List<IFileSystemComponent>();
        }
        public void Display(int depth)
        {
            Console.WriteLine(new String(' ', depth) + $"{name} ({GetSize()}kb)");
            foreach (IFileSystemComponent component in components)
            {
                component.Display(depth + 3);
            }
        }
        public double GetSize()
        {
            double totalSize = 0;
            foreach (IFileSystemComponent component in components)
            {
                totalSize += component.GetSize();
            }
            return totalSize;
        }
        public void AddComponent(IFileSystemComponent component)
        {
            if (!components.Contains(component))
            {
                components.Add(component);
            }
        }
        public void RemoveComponent(IFileSystemComponent component)
        {
            if (components.Contains(component))
            {
                components.Remove(component);
            }
        }
    }
}
