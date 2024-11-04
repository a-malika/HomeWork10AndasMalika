using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class AudioSystem
    {
        private string status = "off";
        private int volume = 20;
        public void audioOn()
        {
            status = "on";
            Console.WriteLine("Audio system is on.");
        }
        public void audioOff()
        {
            status = "off";
            Console.WriteLine("Audio system is off.");
        }
        public void changeVolume(int vol)
        {
            if (status == "on")
            {
                volume = vol;
                Console.WriteLine($"Volume changed to {vol}.");
            }
            else
            {
                Console.WriteLine("Volume cannot be changed. Audio system is off.");
            }
        }
    }
}
