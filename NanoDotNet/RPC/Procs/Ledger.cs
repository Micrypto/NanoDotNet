using System.Numerics;
using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.Ledger
{
    public class History
    {
        private Client.IClient _client;

        private History()
        {
        }

        public History(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Ledger.HistoryResponse> SendRequestAsync(string hash, BigInteger count)
        {
            Requests.Ledger.HistoryRequest request = new Requests.Ledger.HistoryRequest();

            request.action = "history";
            request.hash = hash;
            request.count = count;

            return _client.SendRequestAsync<Responses.Ledger.HistoryResponse>(request);
        }
    }

    public class Ledger
    {
        private Client.IClient _client;

        private Ledger()
        {
        }

        public Ledger(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Ledger.LedgerResponse> SendRequestAsync(string account, BigInteger count, bool representative, bool weight, bool pending)
        {
            Requests.Ledger.LedgerRequest request = new Requests.Ledger.LedgerRequest();

            request.action = "ledger";
            request.account = account;
            request.count = count;
            request.representative = representative;
            request.weight = weight;
            request.pending = pending;

            return _client.SendRequestAsync<Responses.Ledger.LedgerResponse>(request);
        }
    }

    public class Successors
    {
        private Client.IClient _client;

        private Successors()
        {
        }

        public Successors(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Ledger.SuccessorsResponse> SendRequestAsync(string block, BigInteger count)
        {
            Requests.Ledger.SuccessorsRequest request = new Requests.Ledger.SuccessorsRequest();

            request.action = "successors";
            request.block = block;
            request.count = count;

            return _client.SendRequestAsync<Responses.Ledger.SuccessorsResponse>(request);
        }
    }
}
