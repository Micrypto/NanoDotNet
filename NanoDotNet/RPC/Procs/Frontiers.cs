using System.Numerics;
using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.Frontiers
{
    public class Frontiers
    {
        private Client.IClient _client;

        private Frontiers()
        {
        }

        public Frontiers(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Frontiers.FrontiersResponse> SendRequestAsync(string account, BigInteger count)
        {
            Requests.Frontiers.FrontiersRequest request = new Requests.Frontiers.FrontiersRequest();

            request.action = "frontiers";
            request.account = account;
            request.count = count;

            return _client.SendRequestAsync<Responses.Frontiers.FrontiersResponse>(request);
        }
    }

    public class FrontiersCount
    {
        private Client.IClient _client;

        private FrontiersCount()
        {
        }

        public FrontiersCount(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Frontiers.FrontiersCountResponse> SendRequestAsync()
        {
            Requests.Frontiers.FrontiersCountRequest request = new Requests.Frontiers.FrontiersCountRequest();

            request.action = "frontier_count";

            return _client.SendRequestAsync<Responses.Frontiers.FrontiersCountResponse>(request);
        }
    }
}
