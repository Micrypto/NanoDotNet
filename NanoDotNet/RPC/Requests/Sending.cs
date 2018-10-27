using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Requests.Sending
{
    public class SendRequest : Request
    {
        public string wallet;
        public string source;
        public string destination;
        public BigInteger amount;
        public string id;
    }
}
