using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.Network
{
    public class AvailableSupply
    {
        private Client.IClient _client;

        private AvailableSupply()
        {
        }

        public AvailableSupply(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Network.AvailableSupplyResponse> SendRequestAsync()
        {
            Requests.Network.AvailableSupplyRequest request = new Requests.Network.AvailableSupplyRequest();

            request.action = "available_supply";

            return _client.SendRequestAsync<Responses.Network.AvailableSupplyResponse>(request);
        }
    }

    public class Keepalive
    {
        private Client.IClient _client;

        private Keepalive()
        {
        }

        public Keepalive(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Network.KeepaliveResponse> SendRequestAsync(string address, int port)
        {
            Requests.Network.KeepaliveRequest request = new Requests.Network.KeepaliveRequest();

            request.action = "keepalive";
            request.address = address;
            request.port = port;

            return _client.SendRequestAsync<Responses.Network.KeepaliveResponse>(request);
        }
    }

    public class Republish
    {
        private Client.IClient _client;

        private Republish()
        {
        }

        public Republish(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Network.RepublishResponse> SendRequestAsync(string hash)
        {
            Requests.Network.RepublishRequest request = new Requests.Network.RepublishRequest();

            request.action = "republish";
            request.hash = hash;

            return _client.SendRequestAsync<Responses.Network.RepublishResponse>(request);
        }
    }
}
