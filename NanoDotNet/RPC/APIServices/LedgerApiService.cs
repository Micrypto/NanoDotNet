using Micrypto.NanoDotNet.RPC.Procs.Ledger;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class LedgerApiService
    {
        private Client.IClient _client;

        private LedgerApiService()
        {
        }

        public LedgerApiService(Client.IClient client)
        {
            _client = client;
        }

        public History History
        {
            get
            {
                return new History(_client);
            }
        }

        public Ledger Ledger
        {
            get
            {
                return new Ledger(_client);
            }
        }

        public Successors Successors
        {
            get
            {
                return new Successors(_client);
            }
        }
    }
}
