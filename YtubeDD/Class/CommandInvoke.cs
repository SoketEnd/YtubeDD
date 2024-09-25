using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YtubeDD.Class
{
    class CommandInvoke
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public async Task ExecuteCommandAsync()
        {
            if (_command != null)
            {
                await _command.ExecuteAsync();
            }
        }
    }
}
