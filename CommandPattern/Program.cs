using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            /* Define and instantiate the following Vendor classes
             * Kitchen Light : Light
             * Livingroom Light : Light
             * Livingroom ceiling fan : CeilingFan
             * Garage door: Garagedoor
             * Stereo : Stereo
             */
            Light kitchenLight = new Light("Kitchen");

            Light livingRoomLight = new Light("Living Room");

            CeilingFan livingRoomCeilingFan = new CeilingFan("Living Room");

            Light garageLight = new Light("Garage");
            GarageDoor garageDoor = new GarageDoor(garageLight);

            Stereo stereo = new Stereo();
            // Define and instantiate an Off and On command for each Vendor class

            /* Set the On and Off commands to the appropriate slot:
             * 
             * 1: Living Room light
             * 2: Kitchen light
             * 3: Livingroom ceiling fan
             * 4: Garage door
             * 5: Stereo
             */
            Command livingRoomLightOff = new LightOffCommand(livingRoomLight);
            Command livingRoomLightOn = new LightOnCommand(livingRoomLight);
            Command kitchenLightOff = new LightOffCommand(kitchenLight);
            Command kitchenLightOn = new LightOnCommand(kitchenLight);
            Command livingRoomCeilingFanOn = new CeilingFanOnCommand(livingRoomCeilingFan);
            Command livingRoomCeilingFanOff = new CeilingFanOffCommand(livingRoomCeilingFan);
            Command garageDoorOpen = new GarageDoorUpCommand(garageDoor);
            Command garageDoorClose = new GarageDoorDownCommand(garageDoor);
            Command stereoOn = new StereoOnWithDvdCommand(stereo);
            Command stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, livingRoomCeilingFanOn, livingRoomCeilingFanOff);
            remoteControl.SetCommand(3, garageDoorOpen, garageDoorClose);
            remoteControl.SetCommand(4, stereoOn, stereoOff);


            Console.WriteLine(remoteControl);

            Console.WriteLine();
            Console.WriteLine("Testing on and off");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Slot {i}");
                remoteControl.OnButtonWasPushed(i);
                remoteControl.OffButtonWasPushed(i);
            }

            Console.WriteLine();
            Console.WriteLine("Testing undo");

            for (int i = 0; i < 14; i++)
            {
                remoteControl.UndoButtonWasPushed();
            }

            Console.WriteLine();
            Console.WriteLine("Testing cycling ceiling fan");

            remoteControl.OffButtonWasPushed(2);
            for (int i = 0; i < 6; i++)
            {
                remoteControl.OnButtonWasPushed(2);
            }
        }
    }
}