using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class RemoteControl
    {
        public ICommand[] onCommands;
        public ICommand[] offCommands;

        public RemoteControl()
        {
            onCommands = new ICommand[10] { new NoCommand(), new NoCommand(), new NoCommand(), new NoCommand(), new NoCommand(), new NoCommand(), new NoCommand(), new NoCommand(), new NoCommand(), new NoCommand() };
            offCommands = new ICommand[10] { new NoCommand(), new NoCommand(), new NoCommand(), new NoCommand(), new NoCommand(), new NoCommand(), new NoCommand(), new NoCommand(), new NoCommand(), new NoCommand() };
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            if (slot < onCommands.Length)
            {
                onCommands[slot] = onCommand;
                offCommands[slot] = offCommand;
            }
            else
            {
                Console.WriteLine("Slot doesn't exists.");
            }
        }

        public void OnButtonWasPushed(int slot)
        {
            if (slot < onCommands.Length)
            {
                onCommands[slot].Execute();
            }
            else
            {
                Console.WriteLine("Slot doesn't exists.");
            }
        }

        public void OffButtonWasPushed(int slot)
        {
            if (slot < onCommands.Length)
            {
                offCommands[slot].Execute();
            }
            else
            {
                Console.WriteLine("Slot doesn't exists.");
            }
        }

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < onCommands.Length; i++)
            {
                result += onCommands[i].ToString() + " / " + offCommands[i].ToString() + "\n";
            }

            return result;
        }
    }
}
