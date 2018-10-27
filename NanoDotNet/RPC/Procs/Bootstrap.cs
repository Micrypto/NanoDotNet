using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.Bootstrap
{
    public class Bootstrap
    {
        private Client.IClient _client;

        private Bootstrap()
        {
        }

        public Bootstrap(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Bootstrap.BootstrapResponse> SendRequestAsync(string address, int port)
        {
            Requests.Bootstrap.BootstrapRequest request = new Requests.Bootstrap.BootstrapRequest();

            request.action = "bootstrap";
            request.address = address;
            request.port = port;

            return _client.SendRequestAsync<Responses.Bootstrap.BootstrapResponse>(request);
        }
    }

    public class MultiConnectionBootstrap
    {
        private Client.IClient _client;

        private MultiConnectionBootstrap()
        {
        }

        public MultiConnectionBootstrap(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Bootstrap.MultiConnectionBootstrapResponse> SendRequestAsync()
        {
            Requests.Bootstrap.MultiConnectionBootstrapRequest request = new Requests.Bootstrap.MultiConnectionBootstrapRequest();

            request.action = "bootstrap_any";

            return _client.SendRequestAsync<Responses.Bootstrap.MultiConnectionBootstrapResponse>(request);
        }
    }

}
