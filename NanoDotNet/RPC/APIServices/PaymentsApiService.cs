using Micrypto.NanoDotNet.RPC.Procs.Payments;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class PaymentsApiService
    {
        private Client.IClient _client;

        private PaymentsApiService()
        {
        }

        public PaymentsApiService(Client.IClient client)
        {
            _client = client;
        }

        public PaymentBegin PaymentBegin
        {
            get
            {
                return new PaymentBegin(_client);
            }
        }

        public PaymentEnd PaymentEnd
        {
            get
            {
                return new PaymentEnd(_client);
            }
        }

        public PaymentInit PaymentInit
        {
            get
            {
                return new PaymentInit(_client);
            }
        }

        public PaymentWait PaymentWait
        {
            get
            {
                return new PaymentWait(_client);
            }
        }
    }
}