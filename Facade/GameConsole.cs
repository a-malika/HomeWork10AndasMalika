using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class GameConsole
    {
        private string status = "off";
        public void ConsoleOn()
        {
            status = "on";
            Console.WriteLine("Game console is on.");
        }
        public void ConsoleOff()
        {
            status = "off";
            Console.WriteLine("Game console is off.");
        }
        public void PlayGame(string name)
        {
            if (status == "on")
            {
                Console.WriteLine($"Game {name} is started.");
            }
            else
            {
                Console.WriteLine("Game cannot be started. Console is off.");
            }
        }
    }
}
