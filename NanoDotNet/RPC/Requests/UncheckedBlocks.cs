using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Requests.UncheckedBlocks
{
    public class ClearUncheckedBlocksRequest : Request
    {
    }

    public class RetrieveUncheckedBlockRequest : Request
    {
        public string hash;
    }

    public class UncheckedBlocksWithDatabaseKeysRequest : Request
    {
        public string key;
        public BigInteger count;
    }

    public class UncheckedBlocksRequest : Request
    {
        public BigInteger count;
    }

}
