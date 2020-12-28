using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class GarageDoorOpenCommand : ICommand
    {
        private Door _garageDoor;
        public GarageDoorOpenCommand(Door garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void Execute()
        {
            _garageDoor.Open();
        }
    }
}
