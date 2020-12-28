using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class GarageDoorClose : ICommand
    {
        private Door _garageDoor;
        public GarageDoorClose(Door garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void Execute()
        {
            _garageDoor.Close();
        }
    }
}
