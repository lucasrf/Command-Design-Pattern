using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class GarageDoorOpen : ICommand
    {
        private Door _garageDoor;
        public GarageDoorOpen(Door garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void Execute()
        {
            _garageDoor.Open();
        }
    }
}
