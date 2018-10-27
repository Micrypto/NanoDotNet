using Micrypto.NanoDotNet.RPC.Procs.Node;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class NodeApiService
    {
        private Client.IClient _client;

        private NodeApiService()
        {
        }

        public NodeApiService(Client.IClient client)
        {
            _client = client;
        }

        public RetrieveNodeVersions RetrieveNodeVersions
        {
            get
            {
                return new RetrieveNodeVersions(_client);
            }
        }

        public StopNode StopNode
        {
            get
            {
                return new StopNode(_client);
            }
        }
    }
}
