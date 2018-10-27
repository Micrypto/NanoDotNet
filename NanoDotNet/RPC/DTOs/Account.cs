using System.Numerics;
using Newtonsoft.Json;

namespace Micrypto.NanoDotNet.RPC.DTOs
{
    public class Account
    {
        public string frontier;
        [JsonProperty("open_block")]
        public string openBlock;
        [JsonProperty("representative_block")]
        public string representativeBlock;
        public BigInteger balance;
        [JsonProperty("modified_timestamp")]
        public int modifiedTimestamp;
        [JsonProperty("block_count")]
        public int blockCount;
        public string representative;
        public BigInteger weight;
        public BigInteger pending;
    }
}
