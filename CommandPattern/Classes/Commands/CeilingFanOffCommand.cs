using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanOffCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.Off();
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
