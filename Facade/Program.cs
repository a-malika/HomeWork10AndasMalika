using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade(new TV(), new AudioSystem(), new DVDPlayer(), new GameConsole());
            homeTheaterFacade.StartSystemToWatchMovie("Kikoriki");
            homeTheaterFacade.changeVolume(40);
            homeTheaterFacade.StopSystemToWatchMovie();
            homeTheaterFacade.StartGaming("Deadlock");
        }
    }
}
