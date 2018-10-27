using Micrypto.NanoDotNet.RPC.Procs.ProofOfWork;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class ProofOfWorkApiService
    {
        private Client.IClient _client;

        private ProofOfWorkApiService()
        {
        }

        public ProofOfWorkApiService(Client.IClient client)
        {
            _client = client;
        }

        public WorkCancel WorkCancel
        {
            get
            {
                return new WorkCancel(_client);
            }
        }

        public WorkGenerate WorkGenerate
        {
            get
            {
                return new WorkGenerate(_client);
            }
        }

        public WorkGet WorkGet
        {
            get
            {
                return new WorkGet(_client);
            }
        }

        public WorkSet WorkSet
        {
            get
            {
                return new WorkSet(_client);
            }
        }

        public WorkValidate WorkValidate
        {
            get
            {
                return new WorkValidate(_client);
            }
        }
    }
}