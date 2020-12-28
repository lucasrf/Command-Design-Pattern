using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            this._light = light;
        }

        public void Execute()
        {
            this._light.On();
        }
    }
}
