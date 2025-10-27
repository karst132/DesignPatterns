using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanOnCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;
        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            int newSeed = prevSpeed+1;

            if (newSeed > ceilingFan.HIGH) 
            {
                newSeed = ceilingFan.LOW;
            }

            TrySetSpeedCeilingFan(newSeed);
        }

        public void Undo()
        {
            TrySetSpeedCeilingFan(prevSpeed);
        }

        private bool TrySetSpeedCeilingFan(int ceilingFanSpeed)
        {
            if (ceilingFanSpeed == ceilingFan.OFF)
            {
                ceilingFan.Off();
                return true;
            }
            
            if (ceilingFanSpeed == ceilingFan.LOW)
            {
                ceilingFan.Low();
                return true;
            }

            if (ceilingFanSpeed == ceilingFan.MEDIUM)
            {
                ceilingFan.Medium();
                return true;
            }

            if (ceilingFanSpeed == ceilingFan.HIGH)
            {
                ceilingFan.High();
                return true;
            }

            return false;
        }
    }
}
