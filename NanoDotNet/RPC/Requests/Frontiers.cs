using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Requests.Frontiers
{
    public class FrontiersRequest : Request
    {
        public string account;
        public BigInteger count;
    }

    public class FrontiersCountRequest : Request
    {
    }
}
