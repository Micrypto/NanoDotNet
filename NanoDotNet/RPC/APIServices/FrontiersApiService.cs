using Micrypto.NanoDotNet.RPC.Procs.Frontiers;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class FrontiersApiService
    {
        private Client.IClient _client;

        private FrontiersApiService()
        {
        }

        public FrontiersApiService(Client.IClient client)
        {
            _client = client;
        }

        public Frontiers Frontiers
        {
            get
            {
                return new Frontiers(_client);
            }
        }

        public FrontiersCount FrontiersCount
        {
            get
            {
                return new FrontiersCount(_client);
            }
        }
    }
}
