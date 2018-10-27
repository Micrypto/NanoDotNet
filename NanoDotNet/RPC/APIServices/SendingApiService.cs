using Micrypto.NanoDotNet.RPC.Procs.Sending;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class SendingApiService
    {
        private Client.IClient _client;

        private SendingApiService()
        {
        }

        public SendingApiService(Client.IClient client)
        {
            _client = client;
        }

        public Send Send
        {
            get
            {
                return new Send(_client);
            }
        }
    }
}
