namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            PopcornPopper popcornPopper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner(amp);
            HomeTheaterFacade homeTheater = new HomeTheaterFacade(
                amp,
                tuner,
                projector,
                popcornPopper,
                dvdPlayer,
                lights,
                screen,
                cdPlayer);

            homeTheater.WatchMovie("The Hobbit: An Unexpected Journey");
            homeTheater.EndMovie();
        }
    }
}