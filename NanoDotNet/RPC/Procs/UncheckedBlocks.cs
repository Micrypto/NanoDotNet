using System.Numerics;
using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.UncheckedBlocks
{
    public class ClearUncheckedBlocks
    {
        private Client.IClient _client;

        private ClearUncheckedBlocks()
        {
        }

        public ClearUncheckedBlocks(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.UncheckedBlocks.ClearUncheckedBlocksResponse> SendRequestAsync()
        {
            Requests.UncheckedBlocks.ClearUncheckedBlocksRequest request = new Requests.UncheckedBlocks.ClearUncheckedBlocksRequest();

            request.action = "unchecked_clear";

            return _client.SendRequestAsync<Responses.UncheckedBlocks.ClearUncheckedBlocksResponse>(request);
        }
    }

    public class RetrieveUncheckedBlock
    {
        private Client.IClient _client;

        private RetrieveUncheckedBlock()
        {
        }

        public RetrieveUncheckedBlock(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.UncheckedBlocks.RetrieveUncheckedBlockResponse> SendRequestAsync(string hash)
        {
            Requests.UncheckedBlocks.RetrieveUncheckedBlockRequest request = new Requests.UncheckedBlocks.RetrieveUncheckedBlockRequest();

            request.action = "unchecked_get";
            request.hash = hash;

            return _client.SendRequestAsync<Responses.UncheckedBlocks.RetrieveUncheckedBlockResponse>(request);
        }
    }

    public class UncheckedBlocks
    {
        private Client.IClient _client;

        private UncheckedBlocks()
        {
        }

        public UncheckedBlocks(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.UncheckedBlocks.UncheckedBlocksResponse> SendRequestAsync(BigInteger count)
        {
            Requests.UncheckedBlocks.UncheckedBlocksRequest request = new Requests.UncheckedBlocks.UncheckedBlocksRequest();

            request.action = "unchecked_get";
            request.count = count;

            return _client.SendRequestAsync<Responses.UncheckedBlocks.UncheckedBlocksResponse>(request);
        }
    }

    public class UncheckedBlocksWithDatabaseKeys
    {
        private Client.IClient _client;

        private UncheckedBlocksWithDatabaseKeys()
        {
        }

        public UncheckedBlocksWithDatabaseKeys(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.UncheckedBlocks.UncheckedBlocksWithDatabaseKeysResponse> SendRequestAsync(string key, BigInteger count)
        {
            Requests.UncheckedBlocks.UncheckedBlocksWithDatabaseKeysRequest request = new Requests.UncheckedBlocks.UncheckedBlocksWithDatabaseKeysRequest();

            request.action = "unchecked_keys";
            request.key = key;
            request.count = count;

            return _client.SendRequestAsync<Responses.UncheckedBlocks.UncheckedBlocksWithDatabaseKeysResponse>(request);
        }
    }
}
