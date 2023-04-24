namespace Proxy.Step4
{
    public class ProxyVideoDownloader : VideoDownloader
    {
        private readonly VideoDownloader videoDownloader = new RealVideoDownloader();
        private readonly Dictionary<string,Video> VideoCache = new Dictionary<string, Video>(); 

        public Video GetVideo(string videoName)
        {
            if (!VideoCache.Where(a=>a.Key == videoName).Any())
            {
                VideoCache.Add(videoName,videoDownloader.GetVideo(videoName));
            }

            return VideoCache.Where(a => a.Key == videoName).First().Value;
        }
    }
}
