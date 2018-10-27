using Micrypto.NanoDotNet.RPC.Procs.Pending;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class PendingApiService
    {
        private Client.IClient _client;

        private PendingApiService()
        {
        }

        public PendingApiService(Client.IClient client)
        {
            _client = client;
        }

        public Pending Pending
        {
            get
            {
                return new Pending(_client);
            }
        }

        public PendingExists PendingExists
        {
            get
            {
                return new PendingExists(_client);
            }
        }

        public SearchPending SearchPending
        {
            get
            {
                return new SearchPending(_client);
            }
        }

        public SearchPendingAllWallets SearchPendingAllWallets
        {
            get
            {
                return new SearchPendingAllWallets(_client);
            }
        }
    }
}
