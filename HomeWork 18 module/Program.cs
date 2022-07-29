
using HomeWork_18_module;

class Program
{
    static async Task Main(string[] args)
        {
            var user = new User();

            var downloader = new YoutubeDownloader("https://www.youtube.com/watch?v=xTJGrFheNcY");

            var getInfoCommand = new GetInfoCommand(downloader);

            user.SetCommand(getInfoCommand);

            await user.Run();

            var downloadCommand = new DownloadCommand(downloader);

            user.SetCommand(downloadCommand);

            await user.Run();

        }
}