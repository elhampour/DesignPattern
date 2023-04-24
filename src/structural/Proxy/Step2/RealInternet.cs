namespace Proxy.Step2
{
    public class RealInternet : Internet
    {
        public void ConnectTo(string host)
        {
            Console.WriteLine($"Opened connection to {host}");
        }
    }

    public class ProxyInternet : Internet
    {
        private static readonly List<string> bannedSites= new List<string>();
        private readonly Internet internet = new RealInternet();

        public ProxyInternet()
        {
            bannedSites.Add("banned.com");
        }

        public void ConnectTo(string host)
        {
            if (bannedSites.Where(a=>a == host).Any())
            {
                Console.WriteLine($"Access Denined to {host}");
                return;
            }

            internet.ConnectTo(host);
        }
    }
}
