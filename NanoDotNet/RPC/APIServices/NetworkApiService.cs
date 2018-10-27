using Micrypto.NanoDotNet.RPC.Procs.Network;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class NetworkApiService
    {
        private Client.IClient _client;

        private NetworkApiService()
        {
        }

        public NetworkApiService(Client.IClient client)
        {
            _client = client;
        }

        public AvailableSupply AvailableSupply
        {
            get
            {
                return new AvailableSupply(_client);
            }
        }

        public Keepalive Keepalive
        {
            get
            {
                return new Keepalive(_client);
            }
        }

        public Republish Republish
        {
            get
            {
                return new Republish(_client);
            }
        }
    }
}
