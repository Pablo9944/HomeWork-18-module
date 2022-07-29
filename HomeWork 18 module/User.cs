using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18_module
{
    class User
    {
        Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public async Task Run()
        {
            await command.Run();
        }
    }
}
