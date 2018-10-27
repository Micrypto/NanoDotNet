using System.Collections.Generic;
using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Responses.Blocks
{
    public class BlockAccountResponse : Response
    {
        public string account;
    }

    public class BlockCountResponse : Response
    {
        public BigInteger count;
        public BigInteger @unchecked;
    }

    public class BlockCountByTypeResponse : Response
    {
        public BigInteger send;
        public BigInteger receive;
        public BigInteger open;
        public BigInteger change;
    }

    public class ChainResponse : Response
    {
        public string[] blocks;
    }

    public class CreateBlockOpenResponse : Response
    {
        public string hash;
        public string block; // TODO: create Block type.
    }

    public class CreateBlockReceiveResponse : Response
    {
        public string hash;
        public string block; // TODO: create Block type.
    }

    public class CreateBlockSendResponse : Response
    {
        public string hash;
        public string block; // TODO: create Block type.
    }

    public class CreateBlockChangeResponse : Response
    {
        public string hash;
        public string block; // TODO: create Block type.
    }

    public class ProcessBlockResponse : Response
    {
        public string hash;
    }

    public class RetrieveBlockResponse : Response
    {
        public string contents; // TODO: create Block type.
    }

    public class RetrieveBlocksResponse : Response
    {
        public Dictionary<string, DTOs.Block> blocks;
    }

    public class RetrieveBlocksWithInfoResponse : Response
    {
        public Dictionary<string, DTOs.BlockWithAdditionalInfo> blocks;
    }

}
