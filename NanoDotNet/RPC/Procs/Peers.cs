using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.Peers
{
    public class AddWorkPeer
    {
        private Client.IClient _client;

        private AddWorkPeer()
        {
        }

        public AddWorkPeer(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Peers.AddWorkPeerResponse> SendRequestAsync(string address, int port)
        {
            Requests.Peers.AddWorkPeerRequest request = new Requests.Peers.AddWorkPeerRequest();

            request.action = "work_peer_add";
            request.address = address;
            request.port = port;

            return _client.SendRequestAsync<Responses.Peers.AddWorkPeerResponse>(request);
        }
    }

    public class ClearWorkPeers
    {
        private Client.IClient _client;

        private ClearWorkPeers()
        {
        }

        public ClearWorkPeers(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Peers.ClearWorkPeersResponse> SendRequestAsync(string address, int port)
        {
            Requests.Peers.ClearWorkPeersRequest request = new Requests.Peers.ClearWorkPeersRequest();

            request.action = "work_peers_clear";

            return _client.SendRequestAsync<Responses.Peers.ClearWorkPeersResponse>(request);
        }
    }

    public class RetrieveOnlinePeers
    {
        private Client.IClient _client;

        private RetrieveOnlinePeers()
        {
        }

        public RetrieveOnlinePeers(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Peers.RetrieveOnlinePeersResponse> SendRequestAsync()
        {
            Requests.Peers.RetrieveOnlinePeersRequest request = new Requests.Peers.RetrieveOnlinePeersRequest();

            request.action = "peers";

            return _client.SendRequestAsync<Responses.Peers.RetrieveOnlinePeersResponse>(request);
        }
    }

    public class RetrieveWorkPeers
    {
        private Client.IClient _client;

        private RetrieveWorkPeers()
        {
        }

        public RetrieveWorkPeers(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Peers.RetrieveWorkPeersResponse> SendRequestAsync()
        {
            Requests.Peers.RetrieveWorkPeersRequest request = new Requests.Peers.RetrieveWorkPeersRequest();

            request.action = "work_peers";

            return _client.SendRequestAsync<Responses.Peers.RetrieveWorkPeersResponse>(request);
        }
    }
}
