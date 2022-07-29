using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18_module
{
    class DownloadCommand : Command
    {
        YoutubeDownloader downloader;
        public DownloadCommand(YoutubeDownloader downloader)
        {
            this.downloader = downloader;
        }

        public override async Task Run()
        {
            await downloader.Download();
        }
    }
}
