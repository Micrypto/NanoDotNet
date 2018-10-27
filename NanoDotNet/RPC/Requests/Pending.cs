using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Requests.Pending
{
    public class PendingRequest : Request
    {
        public string account;
        public BigInteger count;
    }

    public class PendingExistsRequest : Request
    {
        public string hash;
    }

    public class SearchPendingRequest : Request
    {
        public string wallet;
    }

    public class SearchPendingAllWalletsRequest : Request
    {
    }

}
