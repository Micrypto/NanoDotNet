using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Responses.Network
{
    public class AvailableSupplyResponse : Response
    {
        public BigInteger available;
    }

    public class KeepaliveResponse : Response
    {
        public string success;
    }

    public class RepublishResponse : Response
    {
        public string[] blocks;
    }

}
