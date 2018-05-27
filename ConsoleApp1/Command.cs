using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Command
    {

        public Command(string command, string function)
        {
            this.command = command;
            this.function = function;
        }

       public string command;
       public string function;
    }
}
