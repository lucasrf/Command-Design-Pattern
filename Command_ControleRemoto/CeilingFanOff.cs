using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class CeilingFanOff : ICommand
    {
        private CeilingFan _ceilingFan;
        public CeilingFanOff(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            _ceilingFan.Off();
        }
    }
}
