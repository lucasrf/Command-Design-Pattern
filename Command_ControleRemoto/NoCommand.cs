using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No command registered.");
        }
    }
}
