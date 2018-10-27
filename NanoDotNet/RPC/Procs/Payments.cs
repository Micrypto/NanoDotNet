using System.Numerics;
using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.Payments
{
    public class PaymentBegin
    {
        private Client.IClient _client;

        private PaymentBegin()
        {
        }

        public PaymentBegin(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Payments.PaymentBeginResponse> SendRequestAsync(string wallet)
        {
            Requests.Payments.PaymentBeginRequest request = new Requests.Payments.PaymentBeginRequest();

            request.action = "payment_begin";
            request.wallet = wallet;

            return _client.SendRequestAsync<Responses.Payments.PaymentBeginResponse>(request);
        }
    }

    public class PaymentEnd
    {
        private Client.IClient _client;

        private PaymentEnd()
        {
        }

        public PaymentEnd(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Payments.PaymentEndResponse> SendRequestAsync(string account, string wallet)
        {
            Requests.Payments.PaymentEndRequest request = new Requests.Payments.PaymentEndRequest();

            request.action = "payment_end";
            request.account = account;
            request.wallet = wallet;

            return _client.SendRequestAsync<Responses.Payments.PaymentEndResponse>(request);
        }
    }

    public class PaymentInit
    {
        private Client.IClient _client;

        private PaymentInit()
        {
        }

        public PaymentInit(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Payments.PaymentInitResponse> SendRequestAsync(string wallet)
        {
            Requests.Payments.PaymentInitRequest request = new Requests.Payments.PaymentInitRequest();

            request.action = "payment_init";
            request.wallet = wallet;

            return _client.SendRequestAsync<Responses.Payments.PaymentInitResponse>(request);
        }
    }

    public class PaymentWait
    {
        private Client.IClient _client;

        private PaymentWait()
        {
        }

        public PaymentWait(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Payments.PaymentWaitResponse> SendRequestAsync(string account, BigInteger amount, int timeout)
        {
            Requests.Payments.PaymentWaitRequest request = new Requests.Payments.PaymentWaitRequest();

            request.action = "payment_wait";
            request.account = account;
            request.amount = amount;
            request.timeout = timeout;

            return _client.SendRequestAsync<Responses.Payments.PaymentWaitResponse>(request);
        }
    }
}
