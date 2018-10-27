using System.Numerics;
using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.Keys
{
    public class DeterministicKey
    {
        private Client.IClient _client;

        private DeterministicKey()
        {
        }

        public DeterministicKey(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Keys.DeterministicKeyResponse> SendRequestAsync(BigInteger seed, BigInteger index)
        {
            Requests.Keys.DeterministicKeyRequest request = new Requests.Keys.DeterministicKeyRequest();

            request.action = "deterministic_key";
            request.seed = seed;
            request.index = index;

            return _client.SendRequestAsync<Responses.Keys.DeterministicKeyResponse>(request);
        }
    }

    public class KeyCreate
    {
        private Client.IClient _client;

        private KeyCreate()
        {
        }

        public KeyCreate(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Keys.KeyCreateResponse> SendRequestAsync()
        {
            Requests.Keys.KeyCreateRequest request = new Requests.Keys.KeyCreateRequest();

            request.action = "key_create";

            return _client.SendRequestAsync<Responses.Keys.KeyCreateResponse>(request);
        }
    }

    public class KeyExpand
    {
        private Client.IClient _client;

        private KeyExpand()
        {
        }

        public KeyExpand(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Keys.KeyExpandResponse> SendRequestAsync(string key)
        {
            Requests.Keys.KeyExpandRequest request = new Requests.Keys.KeyExpandRequest();

            request.action = "key_expand";
            request.key = key;

            return _client.SendRequestAsync<Responses.Keys.KeyExpandResponse>(request);
        }
    }
}
