using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.Node
{
    public class RetrieveNodeVersions
    {
        private Client.IClient _client;

        private RetrieveNodeVersions()
        {
        }

        public RetrieveNodeVersions(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Node.RetrieveNodeVersionsResponse> SendRequestAsync()
        {
            Requests.Node.RetrieveNodeVersionsRequest request = new Requests.Node.RetrieveNodeVersionsRequest();

            request.action = "version";

            return _client.SendRequestAsync<Responses.Node.RetrieveNodeVersionsResponse>(request);
        }
    }

    public class StopNode
    {
        private Client.IClient _client;

        private StopNode()
        {
        }

        public StopNode(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Node.StopNodeResponse> SendRequestAsync()
        {
            Requests.Node.StopNodeRequest request = new Requests.Node.StopNodeRequest();

            request.action = "stop";

            return _client.SendRequestAsync<Responses.Node.StopNodeResponse>(request);
        }
    }
}
