namespace Micrypto.NanoDotNet.RPC.Requests.Bootstrap
{
    public class BootstrapRequest : Request
    {
        public string address;
        public int port;
    }

    public class MultiConnectionBootstrapRequest : Request
    {
    }
}
