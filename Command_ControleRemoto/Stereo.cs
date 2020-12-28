using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class Stereo
    {
        public string description;

        public Stereo(string description)
        {
            this.description = description;
        }
        public void SetCD()
        {
            Console.WriteLine(description + " is set for CD input.");
        }
        public void SetDVD()
        {
            Console.WriteLine(description + " is set for DVD input.");
        }

        public void SetRadio()
        {
            Console.WriteLine(description + " is set for Radio input.");
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine(description + " volume set to" + volume + ".");
        }
        public void Off()
        {
            Console.WriteLine(description + " is off.");
        }
        public void On()
        {
            Console.WriteLine(description + " is on.");
        }
    }
}
