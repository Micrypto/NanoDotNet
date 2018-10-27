using System.Numerics;
using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.Pending
{
    public class Pending
    {
        private Client.IClient _client;

        private Pending()
        {
        }

        public Pending(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Pending.PendingResponse> SendRequestAsync(string account, BigInteger count)
        {
            Requests.Pending.PendingRequest request = new Requests.Pending.PendingRequest();

            request.action = "pending";
            request.account = account;
            request.count = count;

            return _client.SendRequestAsync<Responses.Pending.PendingResponse>(request);
        }
    }

    public class PendingExists
    {
        private Client.IClient _client;

        private PendingExists()
        {
        }

        public PendingExists(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Pending.PendingExistsResponse> SendRequestAsync(string hash)
        {
            Requests.Pending.PendingExistsRequest request = new Requests.Pending.PendingExistsRequest();

            request.action = "pending_exists";
            request.hash = hash;

            return _client.SendRequestAsync<Responses.Pending.PendingExistsResponse>(request);
        }
    }

    public class SearchPending
    {
        private Client.IClient _client;

        private SearchPending()
        {
        }

        public SearchPending(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Pending.SearchPendingResponse> SendRequestAsync(string wallet)
        {
            Requests.Pending.SearchPendingRequest request = new Requests.Pending.SearchPendingRequest();

            request.action = "search_pending";
            request.wallet = wallet;

            return _client.SendRequestAsync<Responses.Pending.SearchPendingResponse>(request);
        }
    }

    public class SearchPendingAllWallets
    {
        private Client.IClient _client;

        private SearchPendingAllWallets()
        {
        }

        public SearchPendingAllWallets(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Pending.SearchPendingAllWalletsResponse> SendRequestAsync()
        {
            Requests.Pending.SearchPendingAllWalletsRequest request = new Requests.Pending.SearchPendingAllWalletsRequest();

            request.action = "search_pending_all";

            return _client.SendRequestAsync<Responses.Pending.SearchPendingAllWalletsResponse>(request);
        }
    }
}
