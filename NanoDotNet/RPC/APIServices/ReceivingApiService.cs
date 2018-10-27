using Micrypto.NanoDotNet.RPC.Procs.Receiving;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class ReceivingApiService
    {
        private Client.IClient _client;

        private ReceivingApiService()
        {
        }

        public ReceivingApiService(Client.IClient client)
        {
            _client = client;
        }

        public Receive Receive
        {
            get
            {
                return new Receive(_client);
            }
        }

        public ReceiveMinimum ReceiveMinimum
        {
            get
            {
                return new ReceiveMinimum(_client);
            }
        }

        public ReceiveMinimumSet ReceiveMinimumSet
        {
            get
            {
                return new ReceiveMinimumSet(_client);
            }
        }
    }
}
