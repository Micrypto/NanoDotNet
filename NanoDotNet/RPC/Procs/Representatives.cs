using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.Representatives
{
    public class Representatives
    {
        private Client.IClient _client;

        private Representatives()
        {
        }

        public Representatives(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Representatives.RepresentativesResponse> SendRequestAsync()
        {
            Requests.Representatives.RepresentativesRequest request = new Requests.Representatives.RepresentativesRequest();

            request.action = "representatives";

            return _client.SendRequestAsync<Responses.Representatives.RepresentativesResponse>(request);
        }
    }

    public class WalletRepresentative
    {
        private Client.IClient _client;

        private WalletRepresentative()
        {
        }

        public WalletRepresentative(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Representatives.WalletRepresentativeResponse> SendRequestAsync(string wallet)
        {
            Requests.Representatives.WalletRepresentativeRequest request = new Requests.Representatives.WalletRepresentativeRequest();

            request.action = "wallet_representative";
            request.wallet = wallet;

            return _client.SendRequestAsync<Responses.Representatives.WalletRepresentativeResponse>(request);
        }
    }

    public class WalletRepresentativeSet
    {
        private Client.IClient _client;

        private WalletRepresentativeSet()
        {
        }

        public WalletRepresentativeSet(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Representatives.WalletRepresentativeSetResponse> SendRequestAsync(string wallet, string representative)
        {
            Requests.Representatives.WalletRepresentativeSetRequest request = new Requests.Representatives.WalletRepresentativeSetRequest();

            request.action = "wallet_representative_set";
            request.wallet = wallet;
            request.representative = representative;

            return _client.SendRequestAsync<Responses.Representatives.WalletRepresentativeSetResponse>(request);
        }
    }
}
