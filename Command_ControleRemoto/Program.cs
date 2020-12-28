using System;

namespace Command_ControleRemoto
{
    using System;

    namespace RefactoringGuru.DesignPatterns.Command.Conceptual
    {
        class Program
        {
            static void Main(string[] args)
            {
                RemoteLoader remoteLoader = new RemoteLoader();

                Console.WriteLine(remoteLoader.remoteControl.ToString());

                Console.WriteLine("\n\nRemote control test:");
                remoteLoader.remoteControl.OnButtonWasPushed(0);
                remoteLoader.remoteControl.OffButtonWasPushed(0);
                remoteLoader.remoteControl.OnButtonWasPushed(1);
                remoteLoader.remoteControl.OffButtonWasPushed(1);
                remoteLoader.remoteControl.OnButtonWasPushed(2);
                remoteLoader.remoteControl.OffButtonWasPushed(2);
                remoteLoader.remoteControl.OnButtonWasPushed(3);
                remoteLoader.remoteControl.OffButtonWasPushed(3);
                remoteLoader.remoteControl.OnButtonWasPushed(4);
                remoteLoader.remoteControl.OffButtonWasPushed(4);
                remoteLoader.remoteControl.OnButtonWasPushed(5);
                remoteLoader.remoteControl.OffButtonWasPushed(5);

                Console.WriteLine("\n\nFactory classes test:");
                remoteLoader.livingRoomLight.On();
                remoteLoader.kitchenLight.On();
                remoteLoader.stereo.On();
                remoteLoader.stereo.SetCD();
                remoteLoader.stereo.SetDVD();
                remoteLoader.stereo.Off();
                remoteLoader.kitchenLight.Off();
                remoteLoader.livingRoomCeilingFan.HighSpeed();
                remoteLoader.livingRoomCeilingFan.LowSpeed();
                remoteLoader.livingRoomCeilingFan.GetSpeed();
                remoteLoader.livingRoomLight.Off();
                remoteLoader.garageDoor.Open();

                Console.ReadKey();
            }
        }
    }
}
