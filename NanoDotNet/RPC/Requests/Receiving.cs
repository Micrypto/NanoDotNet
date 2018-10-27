using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Requests.Receiving
{
    public class ReceiveRequest : Request
    {
        public string wallet;
        public string account;
        public string block;
    }

    public class ReceiveMinimumRequest : Request
    {
    }

    public class ReceiveMinimumSetRequest : Request
    {
        public BigInteger amount;
    }

}
