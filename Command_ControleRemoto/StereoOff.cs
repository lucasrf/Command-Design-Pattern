using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class StereoOff : ICommand
    {
        private Stereo _stereo;

        public StereoOff(Stereo stereo)
        {
            this._stereo = stereo;
        }

        public void Execute()
        {
            this._stereo.Off();
        }
    }
}
