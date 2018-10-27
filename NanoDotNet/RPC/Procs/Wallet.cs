using System.Numerics;
using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.Wallet
{
    public class WalletAccountsBalances
    {
        private Client.IClient _client;

        private WalletAccountsBalances()
        {
        }

        public WalletAccountsBalances(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Wallet.WalletAccountsBalancesResponse> SendRequestAsync(string wallet, BigInteger threshold)
        {
            Requests.Wallet.WalletAccountsBalancesRequest request = new Requests.Wallet.WalletAccountsBalancesRequest();

            request.action = "wallet_balances";
            request.wallet = wallet;
            request.threshold = threshold;

            return _client.SendRequestAsync<Responses.Wallet.WalletAccountsBalancesResponse>(request);
        }
    }

    public class WalletAddKey
    {
        private Client.IClient _client;

        private WalletAddKey()
        {
        }

        public WalletAddKey(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Wallet.WalletAddKeyResponse> SendRequestAsync(string wallet, string key, bool work)
        {
            Requests.Wallet.WalletAddKeyRequest request = new Requests.Wallet.WalletAddKeyRequest();

            request.action = "wallet_add";
            request.wallet = wallet;
            request.key = key;
            request.work = work;

            return _client.SendRequestAsync<Responses.Wallet.WalletAddKeyResponse>(request);
        }
    }

    public class WalletChangePassword
    {
        private Client.IClient _client;

        private WalletChangePassword()
        {
        }

        public WalletChangePassword(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Wallet.WalletChangePasswordResponse> SendRequestAsync(string wallet, string password)
        {
            Requests.Wallet.WalletChangePasswordRequest request = new Requests.Wallet.WalletChangePasswordRequest();

            request.action = "password_change";
            request.wallet = wallet;
            request.password = password;

            return _client.SendRequestAsync<Responses.Wallet.WalletChangePasswordResponse>(request);
        }
    }

    public class WalletChangeSeed
    {
        private Client.IClient _client;

        private WalletChangeSeed()
        {
        }

        public WalletChangeSeed(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Wallet.WalletChangeSeedResponse> SendRequestAsync(string wallet, string seed)
        {
            Requests.Wallet.WalletChangeSeedRequest request = new Requests.Wallet.WalletChangeSeedRequest();

            request.action = "wallet_change_seed";
            request.wallet = wallet;
            request.seed = seed;

            return _client.SendRequestAsync<Responses.Wallet.WalletChangeSeedResponse>(request);
        }
    }

    public class WalletContains
    {
        private Client.IClient _client;

        private WalletContains()
        {
        }

        public WalletContains(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Wallet.WalletContainsResponse> SendRequestAsync(string wallet, string account)
        {
            Requests.Wallet.WalletContainsRequest request = new Requests.Wallet.WalletContainsRequest();

            request.action = "wallet_contains";
            request.wallet = wallet;
            request.account = account;

            return _client.SendRequestAsync<Responses.Wallet.WalletContainsResponse>(request);
        }
    }

    public class WalletCreate
    {
        private Client.IClient _client;

        private WalletCreate()
        {
        }

        public WalletCreate(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Wallet.WalletCreateResponse> SendRequestAsync()
        {
            Requests.Wallet.WalletCreateRequest request = new Requests.Wallet.WalletCreateRequest();

            request.action = "wallet_create";

            return _client.SendRequestAsync<Responses.Wallet.WalletCreateResponse>(request);
        }
    }

    public class WalletDestroy
    {
        private Client.IClient _client;

        private WalletDestroy()
        {
        }

        public WalletDestroy(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Wallet.WalletDestroyResponse> SendRequestAsync(string wallet)
        {
            Requests.Wallet.WalletDestroyRequest request = new Requests.Wallet.WalletDestroyRequest();

            request.action = "wallet_destroy";
            request.wallet = wallet;

            return _client.SendRequestAsync<Responses.Wallet.WalletDestroyResponse>(request);
        }
    }

    public class WalletExport
    {
        private Client.IClient _client;

        private WalletExport()
        {
        }

        public WalletExport(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Wallet.WalletExportResponse> SendRequestAsync(string wallet)
        {
            Requests.Wallet.WalletExportRequest request = new Requests.Wallet.WalletExportRequest();

            request.action = "wallet_export";
            request.wallet = wallet;

            return _client.SendRequestAsync<Responses.Wallet.WalletExportResponse>(request);
        }
    }

    public class WalletFrontiers
    {
        private Client.IClient _client;

        private WalletFrontiers()
        {
        }

        public WalletFrontiers(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Wallet.WalletFrontiersResponse> SendRequestAsync(string wallet)
        {
            Requests.Wallet.WalletFrontiersRequest request = new Requests.Wallet.WalletFrontiersRequest();

            request.action = "wallet_frontiers";
            request.wallet = wallet;

            return _client.SendRequestAsync<Responses.Wallet.WalletFrontiersResponse>(request);
        }
    }

    public class WalletLockedCheck
    {
        private Client.IClient _client;

        private WalletLockedCheck()
        {
        }

        public WalletLockedCheck(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Wallet.WalletLockedCheckResponse> SendRequestAsync(string wallet)
        {
            Requests.Wallet.WalletLockedCheckRequest request = new Requests.Wallet.WalletLockedCheckRequest();

            request.action = "wallet_locked";
            request.wallet = wallet;

            return _client.SendRequestAsync<Responses.Wallet.WalletLockedCheckResponse>(request);
        }
    }

    public class WalletPasswordEnter
    {
        private Client.IClient _client;

        private WalletPasswordEnter()
        {
        }

        public WalletPasswordEnter(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Wallet.WalletPasswordEnterResponse> SendRequestAsync(string wallet, string password)
        {
            Requests.Wallet.WalletPasswordEnterRequest request = new Requests.Wallet.WalletPasswordEnterRequest();

            request.action = "password_enter";
            request.wallet = wallet;
            request.password = password;

            return _client.SendRequestAsync<Responses.Wallet.WalletPasswordEnterResponse>(request);
        }
    }

    public class WalletPending
    {
        private Client.IClient _client;

        private WalletPending()
        {
        }

        public WalletPending(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Wallet.WalletPendingResponse> SendRequestAsync(string wallet, BigInteger count, BigInteger threshold, bool source)
        {
            Requests.Wallet.WalletPendingRequest request = new Requests.Wallet.WalletPendingRequest();

            request.action = "wallet_pending";
            request.wallet = wallet;
            request.count = count;
            request.threshold = threshold;
            request.source = source;

            return _client.SendRequestAsync<Responses.Wallet.WalletPendingResponse>(request);
        }
    }

    public class WalletRepresentative
    {
        private Client.IClient _client;

        private WalletRepresentative()
        {
        }

        public WalletRepresentative(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Wallet.WalletRepresentativeResponse> SendRequestAsync(string wallet)
        {
            Requests.Wallet.WalletRepresentativeRequest request = new Requests.Wallet.WalletRepresentativeRequest();

            request.action = "wallet_representative";
            request.wallet = wallet;

            return _client.SendRequestAsync<Responses.Wallet.WalletRepresentativeResponse>(request);
        }
    }

    public class WalletRepresentativeSet
    {
        private Client.IClient _client;

        private WalletRepresentativeSet()
        {
        }

        public WalletRepresentativeSet(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Wallet.WalletRepresentativeSetResponse> SendRequestAsync(string wallet, string representative)
        {
            Requests.Wallet.WalletRepresentativeSetRequest request = new Requests.Wallet.WalletRepresentativeSetRequest();

            request.action = "wallet_representative_set";
            request.wallet = wallet;
            request.representative = representative;

            return _client.SendRequestAsync<Responses.Wallet.WalletRepresentativeSetResponse>(request);
        }
    }

    public class WalletRepublish
    {
        private Client.IClient _client;

        private WalletRepublish()
        {
        }

        public WalletRepublish(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Wallet.WalletRepublishResponse> SendRequestAsync(string wallet, BigInteger count)
        {
            Requests.Wallet.WalletRepublishRequest request = new Requests.Wallet.WalletRepublishRequest();

            request.action = "wallet_republish";
            request.wallet = wallet;
            request.count = count;

            return _client.SendRequestAsync<Responses.Wallet.WalletRepublishResponse>(request);
        }
    }

    public class WalletTotalBalance
    {
        private Client.IClient _client;

        private WalletTotalBalance()
        {
        }

        public WalletTotalBalance(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Wallet.WalletTotalBalanceResponse> SendRequestAsync(string wallet)
        {
            Requests.Wallet.WalletTotalBalanceRequest request = new Requests.Wallet.WalletTotalBalanceRequest();

            request.action = "wallet_balance_total";
            request.wallet = wallet;

            return _client.SendRequestAsync<Responses.Wallet.WalletTotalBalanceResponse>(request);
        }
    }

    public class WalletValidPassword
    {
        private Client.IClient _client;

        private WalletValidPassword()
        {
        }

        public WalletValidPassword(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Wallet.WalletValidPasswordResponse> SendRequestAsync(string wallet)
        {
            Requests.Wallet.WalletValidPasswordRequest request = new Requests.Wallet.WalletValidPasswordRequest();

            request.action = "password_valid";
            request.wallet = wallet;

            return _client.SendRequestAsync<Responses.Wallet.WalletValidPasswordResponse>(request);
        }
    }

    public class WalletWorkGet
    {
        private Client.IClient _client;

        private WalletWorkGet()
        {
        }

        public WalletWorkGet(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Wallet.WalletWorkGetResponse> SendRequestAsync(string wallet)
        {
            Requests.Wallet.WalletWorkGetRequest request = new Requests.Wallet.WalletWorkGetRequest();

            request.action = "wallet_work_get";
            request.wallet = wallet;

            return _client.SendRequestAsync<Responses.Wallet.WalletWorkGetResponse>(request);
        }
    }
}
