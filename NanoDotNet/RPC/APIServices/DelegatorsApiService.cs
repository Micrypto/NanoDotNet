using Micrypto.NanoDotNet.RPC.Procs.Delegators;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class DelegatorsApiService
    {
        private Client.IClient _client;

        private DelegatorsApiService()
        {
        }

        public DelegatorsApiService(Client.IClient client)
        {
            _client = client;
        }

        public Delegators Delegators
        {
            get
            {
                return new Delegators(_client);
            }
        }

        public DelegatorsCount DelegatorsCount
        {
            get
            {
                return new DelegatorsCount(_client);
            }
        }
    }
}
