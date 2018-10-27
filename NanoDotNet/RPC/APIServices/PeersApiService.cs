using Micrypto.NanoDotNet.RPC.Procs.Peers;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class PeersApiService
    {
        private Client.IClient _client;

        private PeersApiService()
        {
        }

        public PeersApiService(Client.IClient client)
        {
            _client = client;
        }

        public AddWorkPeer AddWorkPeer
        {
            get
            {
                return new AddWorkPeer(_client);
            }
        }

        public ClearWorkPeers ClearWorkPeers
        {
            get
            {
                return new ClearWorkPeers(_client);
            }
        }

        public RetrieveOnlinePeers RetrieveOnlinePeers
        {
            get
            {
                return new RetrieveOnlinePeers(_client);
            }
        }

        public RetrieveWorkPeers RetrieveWorkPeers
        {
            get
            {
                return new RetrieveWorkPeers(_client);
            }
        }
    }
}
