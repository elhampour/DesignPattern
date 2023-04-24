namespace Proxy.Step1
{
    public class RealInternet : Internet
    {
        public void ConnectTo(string host)
        {
            if (host == "banned.com")
            {
                Console.WriteLine($"Access Denied to {host}");
                return;
            }
            Console.WriteLine($"Opened connection to {host}");
        }
    }
}
