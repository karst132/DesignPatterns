using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class DvdPlayer
    {
        private Amplifier _amplifier;
        public DvdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("Dvd Player on");
        }
        public void Off()
        {
            Console.WriteLine("Dvd Player off");
        }
        public void Eject()
        {
            Console.WriteLine("Dvd Player eject");
        }
        public void Pause()
        {

        }
        public void Play(string movie)
        {
            Console.WriteLine($"Dvd Player playing \"{movie}\"");
        }
        public void SetSurroundAudio()
        {

        }
        public void SetTWoChannelAudio()
        {

        }
        public void Stop()
        {
            Console.WriteLine("Dvd Player stop");
        }
    }
}
