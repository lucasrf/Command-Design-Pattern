using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class GarageDoorCloseCommand : ICommand
    {
        private Door _garageDoor;
        public GarageDoorCloseCommand(Door garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void Execute()
        {
            _garageDoor.Close();
        }
    }
}
