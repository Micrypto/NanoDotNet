using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.Delegators
{
    public class Delegators
    {
        private Client.IClient _client;

        private Delegators()
        {
        }

        public Delegators(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Delegators.DelegatorsResponse> SendRequestAsync(string account)
        {
            Requests.Delegators.DelegatorsRequest request = new Requests.Delegators.DelegatorsRequest();

            request.action = "delegators";
            request.account = account;

            return _client.SendRequestAsync<Responses.Delegators.DelegatorsResponse>(request);
        }
    }

    public class DelegatorsCount
    {
        private Client.IClient _client;

        private DelegatorsCount()
        {
        }

        public DelegatorsCount(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Delegators.DelegatorsCountResponse> SendRequestAsync(string account)
        {
            Requests.Delegators.DelegatorsCountRequest request = new Requests.Delegators.DelegatorsCountRequest();

            request.action = "delegators_count";
            request.account = account;

            return _client.SendRequestAsync<Responses.Delegators.DelegatorsCountResponse>(request);
        }
    }
}
