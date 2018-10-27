using Micrypto.NanoDotNet.RPC.Procs.Representatives;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class RepresentativesApiService
    {
        private Client.IClient _client;

        private RepresentativesApiService()
        {
        }

        public RepresentativesApiService(Client.IClient client)
        {
            _client = client;
        }

        public Representatives Representatives
        {
            get
            {
                return new Representatives(_client);
            }
        }

        public WalletRepresentative WalletRepresentative
        {
            get
            {
                return new WalletRepresentative(_client);
            }
        }

        public WalletRepresentativeSet WalletRepresentativeSet
        {
            get
            {
                return new WalletRepresentativeSet(_client);
            }
        }
    }
}
