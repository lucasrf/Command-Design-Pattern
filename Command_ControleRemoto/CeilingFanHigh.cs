using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class CeilingFanHigh : ICommand
    {
        private CeilingFan _ceilingFan;
        public CeilingFanHigh(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            _ceilingFan.HighSpeed();
        }
    }
}
