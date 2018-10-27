using Newtonsoft.Json;
using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.DTOs
{
    public class BlockWithAdditionalInfo
    {
        [JsonProperty("block_account")]
        public string blockAccount;
        public BigInteger amount;
        public Block contents;
    }
}
