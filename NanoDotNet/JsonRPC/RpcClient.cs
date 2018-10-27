using Micrypto.NanoDotNet.Client;
using System;
using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.JsonRPC
{
    public class RpcClient : IClient
    {
        private Uri _uri;
        private System.Net.Http.HttpClient _httpClient;

        public RPC.APIServices.AccountsApiService Accounts
        {
            get
            {
                return new RPC.APIServices.AccountsApiService(this);
            }
        }

        public RPC.APIServices.BlocksApiService Blocks
        {
            get
            {
                return new RPC.APIServices.BlocksApiService(this);
            }
        }

        public RPC.APIServices.BootstrapApiService Bootstrap
        {
            get
            {
                return new RPC.APIServices.BootstrapApiService(this);
            }
        }

        public RPC.APIServices.ConversionApiService Conversion
        {
            get
            {
                return new RPC.APIServices.ConversionApiService(this);
            }
        }

        public RPC.APIServices.DelegatorsApiService Delegators
        {
            get
            {
                return new RPC.APIServices.DelegatorsApiService(this);
            }
        }

        public RPC.APIServices.FrontiersApiService Frontiers
        {
            get
            {
                return new RPC.APIServices.FrontiersApiService(this);
            }
        }

        public RPC.APIServices.KeysApiService Keys
        {
            get
            {
                return new RPC.APIServices.KeysApiService(this);
            }
        }

        public RPC.APIServices.LedgerApiService Ledger
        {
            get
            {
                return new RPC.APIServices.LedgerApiService(this);
            }
        }

        public RPC.APIServices.NetworkApiService Network
        {
            get
            {
                return new RPC.APIServices.NetworkApiService(this);
            }
        }

        public RPC.APIServices.NodeApiService Node
        {
            get
            {
                return new RPC.APIServices.NodeApiService(this);
            }
        }

        public RPC.APIServices.PaymentsApiService Payments
        {
            get
            {
                return new RPC.APIServices.PaymentsApiService(this);
            }
        }

        public RPC.APIServices.PeersApiService Peers
        {
            get
            {
                return new RPC.APIServices.PeersApiService(this);
            }
        }

        public RPC.APIServices.PendingApiService Pending
        {
            get
            {
                return new RPC.APIServices.PendingApiService(this);
            }
        }

        public RPC.APIServices.ProofOfWorkApiService ProofOfWork
        {
            get
            {
                return new RPC.APIServices.ProofOfWorkApiService(this);
            }
        }

        public RPC.APIServices.ReceivingApiService Receiving
        {
            get
            {
                return new RPC.APIServices.ReceivingApiService(this);
            }
        }

        public RPC.APIServices.RepresentativesApiService Representatives
        {
            get
            {
                return new RPC.APIServices.RepresentativesApiService(this);
            }
        }

        public RPC.APIServices.SendingApiService Sending
        {
            get
            {
                return new RPC.APIServices.SendingApiService(this);
            }
        }

        public RPC.APIServices.UncheckedBlocksApiService UncheckedBlocks
        {
            get
            {
                return new RPC.APIServices.UncheckedBlocksApiService(this);
            }
        }

        public RPC.APIServices.WalletApiService Wallet
        {
            get
            {
                return new RPC.APIServices.WalletApiService(this);
            }
        }

        private RpcClient()
        {
        }

        public RpcClient(Uri uri)
        {
            _uri = uri;
        }

        public Task<T> SendRequestAsync<T>(RPC.Requests.Request request)
        {
            Task<T> result;

            result = Task<T>.Factory.StartNew(SendRequest<T>, request);

            return result;
        }

        private T SendRequest<T>(object request)
        {
            System.Net.Http.HttpClient httpClient;
            System.Net.Http.StringContent httpContent;

            httpContent = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request), System.Text.Encoding.UTF8, "application/json");

            httpClient = new System.Net.Http.HttpClient();
            var post = httpClient.PostAsync(_uri, httpContent);
            post.Wait();

            var postContent = post.Result.Content.ReadAsStringAsync();
            postContent.Wait();

            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(postContent.Result);
        }
    }
}