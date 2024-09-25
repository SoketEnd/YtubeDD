using System.Diagnostics.Tracing;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YtubeDD.Class;

namespace YtubeDD
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            
            Console.WriteLine("Введите ссылку на видео");

            string VideoUrl = Console.ReadLine();

            if(string.IsNullOrEmpty(VideoUrl))
            {
                Console.WriteLine("Введено пустое значение");
            }
            
            string Path = @"C:\\Users\\skoch\\source\\repos\\YtubeDD\\YtubeDD\\bin\\Debug\\net8.0\\ffmpeg-master-latest-win64-gpl-shared";
            
            var DowlaondVideo = new DownloadVideoCommand(VideoUrl, Path);
            // Создаем команду для получения информации о видео
            var GetInfoVideo = new GetVideoInfo(VideoUrl);
            var Invoker = new CommandInvoke();
            // Выполняем команду для вывода информации
            Invoker.SetCommand(GetInfoVideo);
            await Invoker.ExecuteCommandAsync();
            // Создаем команду для скачивания видео
            var Download = new DownloadVideoCommand(VideoUrl, Path);
            Invoker.SetCommand(Download);

            // Выполняем команду для скачивания видео
            await Invoker.ExecuteCommandAsync();
        }
    }
}
