using System.Numerics;
using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.Sending
{
    public class Send
    {
        private Client.IClient _client;

        private Send()
        {
        }

        public Send(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Sending.SendResponse> SendRequestAsync(string wallet, string source, string destination, BigInteger amount, string guid)
        {
            Requests.Sending.SendRequest request = new Requests.Sending.SendRequest();

            request.action = "send";
            request.wallet = wallet;
            request.source = source;
            request.destination = destination;
            request.amount = amount;
            request.id = guid;

            return _client.SendRequestAsync<Responses.Sending.SendResponse>(request);
        }
    }
}
