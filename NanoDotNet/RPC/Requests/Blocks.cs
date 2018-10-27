using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Requests.Blocks
{
    public class BlockAccountRequest : Request
    {
        public string hash;
    }

    public class BlockCountRequest : Request
    {
    }

    public class BlockCountByTypeRequest : Request
    {
    }

    public class ChainRequest : Request
    {
        public string block;
        public BigInteger count;
    }

    public class CreateBlockOpenRequest : Request
    {
        public string type;
        public string key;
        public string account;
        public string representative;
        public string source;
    }

    public class CreateBlockReceiveRequest : Request
    {
        public string type;
        public string wallet;
        public string account;
        public string source;
        public string previous;
    }

    public class CreateBlockSendRequest : Request
    {
        public string type;
        public string wallet;
        public string account;
        public string destination;
        public BigInteger balance;
        public BigInteger amount;
        public string previous;
    }

    public class CreateBlockChangeRequest : Request
    {
        public string type;
        public string wallet;
        public string account;
        public string representative;
        public string previous;
    }

    public class ProcessBlockRequest : Request
    {
        public string block; // TODO: create Block class.
    }

    public class RetrieveBlockRequest : Request
    {
        public string hash;
    }

    public class RetrieveBlocksRequest : Request
    {
        public string[] hashes;
    }

    public class RetrieveBlocksWithInfoRequest : Request
    {
        public string[] hashes;
        public bool pending;
        public bool source;
    }
}
