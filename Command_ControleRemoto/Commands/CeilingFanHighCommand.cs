using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class CeilingFanHighCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            _ceilingFan.HighSpeed();
        }
    }
}
