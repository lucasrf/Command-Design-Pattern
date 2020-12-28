using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class Light
    {
        public string description;

        public Light(string description)
        {
            this.description = description;
        }
        public void On()
        {
            Console.WriteLine(description + " is on.");
        }
        public void Off()
        {
            Console.WriteLine(description + " is off.");
        }
    }
}
