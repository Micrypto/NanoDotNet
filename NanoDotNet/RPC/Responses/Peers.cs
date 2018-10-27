using Newtonsoft.Json;
using System.Collections.Generic;

namespace Micrypto.NanoDotNet.RPC.Responses.Peers
{
    public class AddWorkPeerResponse : Response
    {
        public string success;
    }

    public class ClearWorkPeersResponse : Response
    {
        public string success;
    }

    public class RetrieveOnlinePeersResponse : Response
    {
        public Dictionary<string, string> peers;
    }

    public class RetrieveWorkPeersResponse : Response
    {
        [JsonProperty("work_peers")]
        public string[] peers;
    }
}
