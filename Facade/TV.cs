using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class TV
    {
        private string status = "off";
        private string channel = "none";
        public void tvOn()
        {
            status = "on";
            Console.WriteLine("Televisor is on.");
        }
        public void tvOff()
        {
            status = "off";
            channel = "none";
            Console.WriteLine("Televisor is off.");
        }
        public void changeCanal(string channel)
        {
            if(status == "on")
            {
                this.channel = channel;
                Console.WriteLine($"Canal changed to {channel}.");
            }
            else
            {
                Console.WriteLine("Chanal cannot be changed. Televisor is off.");
            }
        }
    }
}
