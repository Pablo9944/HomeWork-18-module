using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Videos;

namespace HomeWork_18_module
{
    abstract class Command
    {
        public abstract Task Run();
    }
}
