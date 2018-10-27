using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Requests.Network
{
    public class AvailableSupplyRequest : Request
    {
    }

    public class KeepaliveRequest : Request
    {
        public string address;
        public int port;
    }

    public class RepublishRequest : Request
    {
        public string hash;
        public BigInteger count;
        public BigInteger sources;
        public BigInteger destinations;
    }

}
