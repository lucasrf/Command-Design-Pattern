using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class LightOffCommand : ICommand
    {
        private Light _light;

        public LightOffCommand(Light light)
        {
            this._light = light;
        }

        public void Execute()
        {
            this._light.Off();
        }
    }
}
