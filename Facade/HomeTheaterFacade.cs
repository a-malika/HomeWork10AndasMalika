using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class HomeTheaterFacade
    {
        private TV tv;
        private AudioSystem audioSystem;
        private DVDPlayer dvdPlayer;
        private GameConsole gameConsole;
        public HomeTheaterFacade(TV tv, AudioSystem audioSystem, DVDPlayer dvdPlayer, GameConsole gameConsole)
        {
            this.tv = tv;
            this.audioSystem = audioSystem;
            this.dvdPlayer = dvdPlayer;
            this.gameConsole = gameConsole;
        }
        public void StartSystemToWatchMovie(string channel)
        {
            tv.tvOn();
            tv.changeCanal(channel);
            dvdPlayer.Play();
            audioSystem.audioOn();
            Console.WriteLine();
        }
        public void StopSystemToWatchMovie()
        {
            dvdPlayer.Stop();
            audioSystem.audioOff();
            tv.tvOff();
            Console.WriteLine();
        }
        public void StartGaming(string game)
        {
            tv.tvOn();
            gameConsole.ConsoleOn();
            gameConsole.PlayGame(game);
            Console.WriteLine();
        }
        public void changeVolume(int volume)
        {
            audioSystem.audioOn();
            audioSystem.changeVolume(volume);
            Console.WriteLine();
        }
    }
}
