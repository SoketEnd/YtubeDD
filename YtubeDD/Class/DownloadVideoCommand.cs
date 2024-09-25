using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YtubeDD.Class
{
    public class DownloadVideoCommand : ICommand
    {
        private string _Url;
        private string _Path;

        public DownloadVideoCommand(string url, string path)
        {
            _Url = url;
            _Path = path;
        }

        public async Task ExecuteAsync()
        {
            var youtube = new YoutubeClient();

            var video = await youtube.Videos.GetAsync(_Url);
            Console.WriteLine($"Будет скачено видео: {video.Title}");

            await youtube.Videos.DownloadAsync(_Url,_Path, builder =>
            builder.SetPreset(ConversionPreset.UltraFast));
        }
    }
}
