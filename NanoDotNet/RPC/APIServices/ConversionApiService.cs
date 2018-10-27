using Micrypto.NanoDotNet.RPC.Procs.Conversion;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class ConversionApiService
    {
        private Client.IClient _client;

        private ConversionApiService()
        {
        }

        public ConversionApiService(Client.IClient client)
        {
            _client = client;
        }

        public KRaiFromRaw KRaiFromRaw
        {
            get
            {
                return new KRaiFromRaw(_client);
            }
        }

        public KRaiToRaw KRaiToRaw
        {
            get
            {
                return new KRaiToRaw(_client);
            }
        }

        public MRaiFromRaw MRaiFromRaw
        {
            get
            {
                return new MRaiFromRaw(_client);
            }
        }

        public MRaiToRaw MRaiToRaw
        {
            get
            {
                return new MRaiToRaw(_client);
            }
        }

        public RaiFromRaw RaiFromRaw
        {
            get
            {
                return new RaiFromRaw(_client);
            }
        }

        public RaiToRaw RaiToRaw
        {
            get
            {
                return new RaiToRaw(_client);
            }
        }
    }

}
