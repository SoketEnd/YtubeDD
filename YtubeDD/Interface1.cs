using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YtubeDD
{
    interface ICommand
    {
        Task ExecuteAsync();
    }
}
