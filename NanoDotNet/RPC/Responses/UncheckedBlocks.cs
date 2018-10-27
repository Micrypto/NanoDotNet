using System.Collections.Generic;

namespace Micrypto.NanoDotNet.RPC.Responses.UncheckedBlocks
{
    public class ClearUncheckedBlocksResponse : Response
    {
        public string success;
    }

    public class RetrieveUncheckedBlockResponse : Response
    {
        public DTOs.Block @unchecked;
        public string hash;
    }

    public class UncheckedBlocksWithDatabaseKeysResponse : Response
    {
        public DTOs.UncheckedBlock[] @unchecked;
    }

    public class UncheckedBlocksResponse : Response
    {
        public Dictionary<string, DTOs.Block> blocks;
    }

}
