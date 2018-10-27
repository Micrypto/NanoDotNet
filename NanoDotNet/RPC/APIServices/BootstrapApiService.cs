using Micrypto.NanoDotNet.RPC.Procs.Bootstrap;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class BootstrapApiService
    {
        private Client.IClient _client;

        private BootstrapApiService()
        {
        }

        public BootstrapApiService(Client.IClient client)
        {
            _client = client;
        }

        public Bootstrap Bootstrap
        {
            get
            {
                return new Bootstrap(_client);
            }
        }

        public MultiConnectionBootstrap MultiConnectionBootstrap
        {
            get
            {
                return new MultiConnectionBootstrap(_client);
            }
        }
    }

}
