using System.Numerics;
using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.Conversion
{
    public class MRaiFromRaw
    {
        private Client.IClient _client;

        private MRaiFromRaw()
        {
        }

        public MRaiFromRaw(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Conversion.MRaiFromRawResponse> SendRequestAsync(BigInteger amount)
        {
            Requests.Conversion.MRaiFromRawRequest request = new Requests.Conversion.MRaiFromRawRequest();

            request.action = "mrai_from_raw";
            request.amount = amount;

            return _client.SendRequestAsync<Responses.Conversion.MRaiFromRawResponse>(request);
        }
    }

    public class MRaiToRaw
    {
        private Client.IClient _client;

        private MRaiToRaw()
        {
        }

        public MRaiToRaw(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Conversion.MRaiToRawResponse> SendRequestAsync(BigInteger amount)
        {
            Requests.Conversion.MRaiToRawRequest request = new Requests.Conversion.MRaiToRawRequest();

            request.action = "mrai_to_raw";
            request.amount = amount;

            return _client.SendRequestAsync<Responses.Conversion.MRaiToRawResponse>(request);
        }
    }

    public class KRaiFromRaw
    {
        private Client.IClient _client;

        private KRaiFromRaw()
        {
        }

        public KRaiFromRaw(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Conversion.KRaiFromRawResponse> SendRequestAsync(BigInteger amount)
        {
            Requests.Conversion.KRaiFromRawRequest request = new Requests.Conversion.KRaiFromRawRequest();

            request.action = "krai_from_raw";
            request.amount = amount;

            return _client.SendRequestAsync<Responses.Conversion.KRaiFromRawResponse>(request);
        }
    }

    public class KRaiToRaw
    {
        private Client.IClient _client;

        private KRaiToRaw()
        {
        }

        public KRaiToRaw(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Conversion.KRaiToRawResponse> SendRequestAsync(BigInteger amount)
        {
            Requests.Conversion.KRaiToRawRequest request = new Requests.Conversion.KRaiToRawRequest();

            request.action = "krai_to_raw";
            request.amount = amount;

            return _client.SendRequestAsync<Responses.Conversion.KRaiToRawResponse>(request);
        }
    }

    public class RaiFromRaw
    {
        private Client.IClient _client;

        private RaiFromRaw()
        {
        }

        public RaiFromRaw(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Conversion.RaiFromRawResponse> SendRequestAsync(BigInteger amount)
        {
            Requests.Conversion.RaiFromRawRequest request = new Requests.Conversion.RaiFromRawRequest();

            request.action = "rai_from_raw";
            request.amount = amount;

            return _client.SendRequestAsync<Responses.Conversion.RaiFromRawResponse>(request);
        }
    }

    public class RaiToRaw
    {
        private Client.IClient _client;

        private RaiToRaw()
        {
        }

        public RaiToRaw(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Conversion.RaiToRawResponse> SendRequestAsync(BigInteger amount)
        {
            Requests.Conversion.RaiToRawRequest request = new Requests.Conversion.RaiToRawRequest();

            request.action = "rai_to_raw";
            request.amount = amount;

            return _client.SendRequestAsync<Responses.Conversion.RaiToRawResponse>(request);
        }
    }
}
