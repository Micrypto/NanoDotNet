using Micrypto.NanoDotNet.RPC.Procs.Keys;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class KeysApiService
    {
        private Client.IClient _client;

        private KeysApiService()
        {
        }

        public KeysApiService(Client.IClient client)
        {
            _client = client;
        }

        public DeterministicKey DeterministicKey
        {
            get
            {
                return new DeterministicKey(_client);
            }
        }

        public KeyCreate KeyCreate
        {
            get
            {
                return new KeyCreate(_client);
            }
        }

        public KeyExpand KeyExpand
        {
            get
            {
                return new KeyExpand(_client);
            }
        }
    }
}
