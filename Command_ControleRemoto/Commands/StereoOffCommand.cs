using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class StereoOffCommand : ICommand
    {
        private Stereo _stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this._stereo = stereo;
        }

        public void Execute()
        {
            this._stereo.Off();
        }
    }
}
