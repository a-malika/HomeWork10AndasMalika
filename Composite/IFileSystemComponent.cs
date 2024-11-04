using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public interface IFileSystemComponent
    {
        void Display(int depth);
        double GetSize();
    }
}
