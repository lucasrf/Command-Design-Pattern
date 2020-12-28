using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class RemoteLoader
    {
        public RemoteControl remoteControl;
        public Light livingRoomLight;
        public Light kitchenLight;
        public CeilingFan livingRoomCeilingFan;
        public Door garageDoor;
        public Stereo stereo;

        public RemoteLoader()
        {
            remoteControl = new RemoteControl();
            livingRoomLight = new Light("Living Room Light");
            kitchenLight = new Light("Kitchen Light");
            livingRoomCeilingFan = new CeilingFan("Living Room Ceiling Fan");
            garageDoor = new Door("Garage Door");
            stereo = new Stereo("Stereo");
            Main();
        }
        public void Main()
        {
            remoteControl.SetCommand(0, new LightOnCommand(livingRoomLight), new LightOffCommand(livingRoomLight));
            remoteControl.SetCommand(1, new LightOnCommand(kitchenLight), new LightOffCommand(kitchenLight));
            remoteControl.SetCommand(2, new CeilingFanHigh(livingRoomCeilingFan), new CeilingFanOff(livingRoomCeilingFan));
            remoteControl.SetCommand(3, new GarageDoorOpen(garageDoor), new GarageDoorClose(garageDoor));
            remoteControl.SetCommand(4, new StereoOnForCd(stereo), new StereoOff(stereo));
        }
    }
}
