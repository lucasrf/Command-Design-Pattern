using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class StereoOnForCdCommand : ICommand
    {
        private Stereo _stereo;

        public StereoOnForCdCommand(Stereo stereo)
        {
            this._stereo = stereo;
        }

        public void Execute()
        {
            this._stereo.On();
            this._stereo.SetCD();
        }
    }
}
