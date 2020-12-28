using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class Door
    {
        public string description;

        public Door(string description)
        {
            this.description = description;
        }
        public void Open()
        {
            Console.WriteLine(description + " is open.");
        }
        public void Close()
        {
            Console.WriteLine(description + " is closed.");
        }
    }
}
