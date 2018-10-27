using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.ProofOfWork
{
    public class WorkCancel
    {
        private Client.IClient _client;

        private WorkCancel()
        {
        }

        public WorkCancel(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.ProofOfWork.WorkCancelResponse> SendRequestAsync(string hash)
        {
            Requests.ProofOfWork.WorkCancelRequest request = new Requests.ProofOfWork.WorkCancelRequest();

            request.action = "work_cancel";
            request.hash = hash;

            return _client.SendRequestAsync<Responses.ProofOfWork.WorkCancelResponse>(request);
        }
    }

    public class WorkGenerate
    {
        private Client.IClient _client;

        private WorkGenerate()
        {
        }

        public WorkGenerate(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.ProofOfWork.WorkGenerateResponse> SendRequestAsync(string hash)
        {
            Requests.ProofOfWork.WorkGenerateRequest request = new Requests.ProofOfWork.WorkGenerateRequest();

            request.action = "work_generate";
            request.hash = hash;

            return _client.SendRequestAsync<Responses.ProofOfWork.WorkGenerateResponse>(request);
        }
    }

    public class WorkGet
    {
        private Client.IClient _client;

        private WorkGet()
        {
        }

        public WorkGet(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.ProofOfWork.WorkGetResponse> SendRequestAsync(string wallet, string account)
        {
            Requests.ProofOfWork.WorkGetRequest request = new Requests.ProofOfWork.WorkGetRequest();

            request.action = "work_get";
            request.wallet = wallet;
            request.account = account;

            return _client.SendRequestAsync<Responses.ProofOfWork.WorkGetResponse>(request);
        }
    }

    public class WorkSet
    {
        private Client.IClient _client;

        private WorkSet()
        {
        }

        public WorkSet(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.ProofOfWork.WorkSetResponse> SendRequestAsync(string wallet, string account, string work)
        {
            Requests.ProofOfWork.WorkSetRequest request = new Requests.ProofOfWork.WorkSetRequest();

            request.action = "work_set";
            request.wallet = wallet;
            request.account = account;
            request.work = work;

            return _client.SendRequestAsync<Responses.ProofOfWork.WorkSetResponse>(request);
        }
    }

    public class WorkValidate
    {
        private Client.IClient _client;

        private WorkValidate()
        {
        }

        public WorkValidate(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.ProofOfWork.WorkValidateResponse> SendRequestAsync(string work, string hash)
        {
            Requests.ProofOfWork.WorkValidateRequest request = new Requests.ProofOfWork.WorkValidateRequest();

            request.action = "work_validate";
            request.work = work;
            request.hash = hash;

            return _client.SendRequestAsync<Responses.ProofOfWork.WorkValidateResponse>(request);
        }
    }
}
