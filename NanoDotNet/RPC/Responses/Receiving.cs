using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Responses.Receiving
{
    public class ReceiveResponse : Response
    {
        public string block;
    }

    public class ReceiveMinimumResponse : Response
    {
        public BigInteger amount;
    }

    public class ReceiveMinimumSetResponse : Response
    {
        public string success;
    }

}
