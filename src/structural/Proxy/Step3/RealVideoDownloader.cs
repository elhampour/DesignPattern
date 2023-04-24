namespace Proxy.Step3
{
    public class RealVideoDownloader : VideoDownloader
    {
        public Video GetVideo(string videoName)
        {
            Console.WriteLine("Connecting to https://youtube.com");
            Console.WriteLine("Downloading video");
            Console.WriteLine("Retrivigin video meta data");
            return new Video(videoName);
        }
    }
}
