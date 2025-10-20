using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class HomeTheaterFacade
    {
        private Amplifier amplifier;

        private Tuner tuner;

        private Projector projector;

        private PopcornPopper popcornPopper;

        private DvdPlayer dvdPlayer;

        private TheaterLights lights;

        private Screen screen;

        private CdPlayer cdPlayer;

        public HomeTheaterFacade(
            Amplifier amplifier,
            Tuner tuner,
            Projector projector,
            PopcornPopper popcornPopper,
            DvdPlayer dvdPlayer,
            TheaterLights lights,
            Screen screen,
            CdPlayer cdPlayer) 
        {
            this.amplifier = amplifier;
            this.tuner = tuner;
            this.projector = projector;
            this.popcornPopper = popcornPopper;
            this.dvdPlayer = dvdPlayer;
            this.lights = lights;
            this.screen = screen;
            this.cdPlayer = cdPlayer;
        }

        public void WatchMovie(string movieName) 
        {
            popcornPopper.On();
            popcornPopper.Pop();

            lights.On();
            lights.Dim(10);

            screen.Down();

            projector.On();
            projector.SetInput(dvdPlayer);
            projector.WideScreenMode();

            amplifier.On();
            amplifier.SetDvd(dvdPlayer);
            amplifier.SetSurroundSound();
            amplifier.SetVolume(5);

            dvdPlayer.On();
            dvdPlayer.Play(movieName);
        }

        public void EndMovie() {
            dvdPlayer.Stop();
            dvdPlayer.Eject();
            dvdPlayer.Off();

            amplifier.Off();

            projector.Off();

            screen.Up();

            lights.Off();

            popcornPopper.Off();
        }
    }
}
