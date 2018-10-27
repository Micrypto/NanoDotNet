using System.Numerics;
using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.Receiving
{
    public class Receive
    {
        private Client.IClient _client;

        private Receive()
        {
        }

        public Receive(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Receiving.ReceiveResponse> SendRequestAsync(string wallet, string account, string block)
        {
            Requests.Receiving.ReceiveRequest request = new Requests.Receiving.ReceiveRequest();

            request.action = "receive";
            request.wallet = wallet;
            request.account = account;
            request.block = block;

            return _client.SendRequestAsync<Responses.Receiving.ReceiveResponse>(request);
        }
    }

    public class ReceiveMinimum
    {
        private Client.IClient _client;

        private ReceiveMinimum()
        {
        }

        public ReceiveMinimum(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Receiving.ReceiveMinimumResponse> SendRequestAsync()
        {
            Requests.Receiving.ReceiveMinimumRequest request = new Requests.Receiving.ReceiveMinimumRequest();

            request.action = "receive_minimum";

            return _client.SendRequestAsync<Responses.Receiving.ReceiveMinimumResponse>(request);
        }
    }

    public class ReceiveMinimumSet
    {
        private Client.IClient _client;

        private ReceiveMinimumSet()
        {
        }

        public ReceiveMinimumSet(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Receiving.ReceiveMinimumSetResponse> SendRequestAsync(BigInteger amount)
        {
            Requests.Receiving.ReceiveMinimumSetRequest request = new Requests.Receiving.ReceiveMinimumSetRequest();

            request.action = "receive_minimum_set";
            request.amount = amount;

            return _client.SendRequestAsync<Responses.Receiving.ReceiveMinimumSetResponse>(request);
        }
    }
}
