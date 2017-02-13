﻿using SharpDX.XInput;
using System;

namespace FO4_ExpandedLauncher.Domain
{
    class currentXInputDevice
    {
        private Controller[] xDevices = new[] { new Controller(UserIndex.One), new Controller(UserIndex.Two), new Controller(UserIndex.Three), new Controller(UserIndex.Four) };

        //Returns first connected xInput controller
        public Controller getActiveController()
        {
            foreach (Controller device in xDevices)
            {
                if (device.IsConnected == true)
                {
                    Console.WriteLine("Returning a valid controller");
                    //Return first connected controller
                    return device;
                }
            }
            return null;
        }

        //Returns pressed button as a string
        public string getPressedButton(GamepadButtonFlags e)
        {

            string buttons = e.ToString();

            //Get the first button
            int index = buttons.IndexOf(',');
            if (buttons.Contains(","))
            {
                if (index > 0)
                {
                    return buttons.Substring(0, index);
                }
                return null;
            }
            return buttons;
        }
    }
}
