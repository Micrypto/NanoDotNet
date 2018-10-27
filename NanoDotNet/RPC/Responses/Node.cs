using Newtonsoft.Json;

namespace Micrypto.NanoDotNet.RPC.Responses.Node
{
    public class RetrieveNodeVersionsResponse : Response
    {
        [JsonProperty("rpc_version")]
        public string rpcVersion;
        [JsonProperty("store_version")]
        public string storeVersion;
        [JsonProperty("node_vendor")]
        public string nodeVendor;
    }

    public class StopNodeResponse : Response
    {
        public string success;
    }
}
