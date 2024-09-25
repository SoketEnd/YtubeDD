using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YtubeDD.Class
{
    internal class GetVideoInfo : ICommand
    {
        private readonly string _UrlVideo;

        public GetVideoInfo(string urlVideo)
        {
            _UrlVideo = urlVideo;
        }

        public async Task ExecuteAsync()
        {
            var youtube = new YoutubeClient();

            var video = await youtube.Videos.GetAsync(_UrlVideo);

            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Description: {video.Description}");
        }
    }
}
