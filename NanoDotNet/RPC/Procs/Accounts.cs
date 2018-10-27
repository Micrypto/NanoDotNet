using System.Numerics;
using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.Accounts
{
    public class AccountBalance
    {
        private Client.IClient _client;

        private AccountBalance()
        {
        }

        public AccountBalance(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Accounts.AccountBalanceResponse> SendRequestAsync(string account)
        {
            Requests.Accounts.AccountBalanceRequest request = new Requests.Accounts.AccountBalanceRequest();

            request.action = "account_balance";
            request.account = account;

            return _client.SendRequestAsync<Responses.Accounts.AccountBalanceResponse>(request);
        }
    }

    public class AccountBlockCount
    {
        private Client.IClient _client;

        private AccountBlockCount()
        {
        }

        public AccountBlockCount(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Accounts.AccountBlockCountResponse> SendRequestAsync(string account)
        {
            Requests.Accounts.AccountBlockCountRequest request = new Requests.Accounts.AccountBlockCountRequest();

            request.action = "account_block_count";
            request.account = account;

            return _client.SendRequestAsync<Responses.Accounts.AccountBlockCountResponse>(request);
        }
    }

    public class AccountCreate
    {
        private Client.IClient _client;

        private AccountCreate()
        {
        }

        public AccountCreate(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Accounts.AccountCreateResponse> SendRequestAsync(string wallet)
        {
            Requests.Accounts.AccountCreateRequest request = new Requests.Accounts.AccountCreateRequest();

            request.action = "account_create";
            request.wallet = wallet;

            return _client.SendRequestAsync<Responses.Accounts.AccountCreateResponse>(request);
        }
    }

    public class AccountGet
    {
        private Client.IClient _client;

        private AccountGet()
        {
        }

        public AccountGet(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Accounts.AccountGetResponse> SendRequestAsync(string key)
        {
            Requests.Accounts.AccountGetRequest request = new Requests.Accounts.AccountGetRequest();

            request.action = "account_get";
            request.key = key;

            return _client.SendRequestAsync<Responses.Accounts.AccountGetResponse>(request);
        }
    }

    public class AccountHistory
    {
        private Client.IClient _client;

        private AccountHistory()
        {
        }

        public AccountHistory(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Accounts.AccountHistoryResponse> SendRequestAsync(string account, BigInteger count)
        {
            Requests.Accounts.AccountHistoryRequest request = new Requests.Accounts.AccountHistoryRequest();

            request.action = "account_history";
            request.account = account;
            request.count = count;

            return _client.SendRequestAsync<Responses.Accounts.AccountHistoryResponse>(request);
        }
    }

    public class AccountInfo
    {
        private Client.IClient _client;

        private AccountInfo()
        {
        }

        public AccountInfo(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Accounts.AccountInfoResponse> SendRequestAsync(string account)
        {
            Requests.Accounts.AccountInfoRequest request = new Requests.Accounts.AccountInfoRequest();

            request.action = "account_info";
            request.account = account;

            return _client.SendRequestAsync<Responses.Accounts.AccountInfoResponse>(request);
        }
    }

    public class AccountList
    {
        private Client.IClient _client;

        private AccountList()
        {
        }

        public AccountList(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Accounts.AccountListResponse> SendRequestAsync(string wallet)
        {
            Requests.Accounts.AccountListRequest request = new Requests.Accounts.AccountListRequest();

            request.action = "account_list";
            request.wallet = wallet;

            return _client.SendRequestAsync<Responses.Accounts.AccountListResponse>(request);
        }
    }

    public class AccountMove
    {
        private Client.IClient _client;

        private AccountMove()
        {
        }

        public AccountMove(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Accounts.AccountMoveResponse> SendRequestAsync(string wallet, string source, string[] accounts)
        {
            Requests.Accounts.AccountMoveRequest request = new Requests.Accounts.AccountMoveRequest();

            request.action = "account_move";
            request.wallet = wallet;
            request.source = source;
            request.accounts = accounts;

            return _client.SendRequestAsync<Responses.Accounts.AccountMoveResponse>(request);
        }
    }

    public class AccountPublicKey
    {
        private Client.IClient _client;

        private AccountPublicKey()
        {
        }

        public AccountPublicKey(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Accounts.AccountPublicKeyResponse> SendRequestAsync(string account)
        {
            Requests.Accounts.AccountPublicKeyRequest request = new Requests.Accounts.AccountPublicKeyRequest();

            request.action = "account_key";
            request.account = account;

            return _client.SendRequestAsync<Responses.Accounts.AccountPublicKeyResponse>(request);
        }
    }

    public class AccountRemove
    {
        private Client.IClient _client;

        private AccountRemove()
        {
        }

        public AccountRemove(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Accounts.AccountRemoveResponse> SendRequestAsync(string wallet, string account)
        {
            Requests.Accounts.AccountRemoveRequest request = new Requests.Accounts.AccountRemoveRequest();

            request.action = "account_remove";
            request.wallet = wallet;
            request.account = account;

            return _client.SendRequestAsync<Responses.Accounts.AccountRemoveResponse>(request);
        }
    }

    public class AccountRepresentative
    {
        private Client.IClient _client;

        private AccountRepresentative()
        {
        }

        public AccountRepresentative(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Accounts.AccountRepresentativeResponse> SendRequestAsync(string account)
        {
            Requests.Accounts.AccountRepresentativeRequest request = new Requests.Accounts.AccountRepresentativeRequest();

            request.action = "account_representative";
            request.account = account;

            return _client.SendRequestAsync<Responses.Accounts.AccountRepresentativeResponse>(request);
        }
    }

    public class AccountRepresentativeSet
    {
        private Client.IClient _client;

        private AccountRepresentativeSet()
        {
        }

        public AccountRepresentativeSet(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Accounts.AccountRepresentativeSetResponse> SendRequestAsync(string wallet, string account, string representative)
        {
            Requests.Accounts.AccountRepresentativeSetRequest request = new Requests.Accounts.AccountRepresentativeSetRequest();

            request.action = "account_representative_set";
            request.wallet = wallet;
            request.account = account;
            request.representative = representative;

            return _client.SendRequestAsync<Responses.Accounts.AccountRepresentativeSetResponse>(request);
        }
    }

    public class AccountWeight
    {
        private Client.IClient _client;

        private AccountWeight()
        {
        }

        public AccountWeight(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Accounts.AccountWeightResponse> SendRequestAsync(string account)
        {
            Requests.Accounts.AccountWeightRequest request = new Requests.Accounts.AccountWeightRequest();

            request.action = "account_weight";
            request.account = account;

            return _client.SendRequestAsync<Responses.Accounts.AccountWeightResponse>(request);
        }
    }

    public class AccountsBalances
    {
        private Client.IClient _client;

        private AccountsBalances()
        {
        }

        public AccountsBalances(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Accounts.AccountsBalancesResponse> SendRequestAsync(string[] accounts)
        {
            Requests.Accounts.AccountsBalancesRequest request = new Requests.Accounts.AccountsBalancesRequest();

            request.action = "accounts_balances";
            request.accounts = accounts;

            return _client.SendRequestAsync<Responses.Accounts.AccountsBalancesResponse>(request);
        }
    }

    public class AccountsCreate
    {
        private Client.IClient _client;

        private AccountsCreate()
        {
        }

        public AccountsCreate(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Accounts.AccountsCreateResponse> SendRequestAsync(string wallet, BigInteger count)
        {
            Requests.Accounts.AccountsCreateRequest request = new Requests.Accounts.AccountsCreateRequest();

            request.action = "accounts_create";
            request.wallet = wallet;
            request.count = count;

            return _client.SendRequestAsync<Responses.Accounts.AccountsCreateResponse>(request);
        }
    }

    public class AccountsFrontiers
    {
        private Client.IClient _client;

        private AccountsFrontiers()
        {
        }

        public AccountsFrontiers(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Accounts.AccountsFrontiersResponse> SendRequestAsync(string[] accounts)
        {
            Requests.Accounts.AccountsFrontiersRequest request = new Requests.Accounts.AccountsFrontiersRequest();

            request.action = "accounts_frontiers";
            request.accounts = accounts;

            return _client.SendRequestAsync<Responses.Accounts.AccountsFrontiersResponse>(request);
        }
    }

    public class AccountsPending
    {
        private Client.IClient _client;

        private AccountsPending()
        {
        }

        public AccountsPending(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Accounts.AccountsPendingResponse> SendRequestAsync(string[] accounts, BigInteger count)
        {
            Requests.Accounts.AccountsPendingRequest request = new Requests.Accounts.AccountsPendingRequest();

            request.action = "accounts_pending";
            request.accounts = accounts;
            request.count = count;

            return _client.SendRequestAsync<Responses.Accounts.AccountsPendingResponse>(request);
        }
    }

    public class ValidateAccountNumberChecksum
    {
        private Client.IClient _client;

        private ValidateAccountNumberChecksum()
        {
        }

        public ValidateAccountNumberChecksum(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Accounts.ValidateAccountNumberChecksumResponse> SendRequestAsync(string account)
        {
            Requests.Accounts.ValidateAccountNumberChecksumRequest request = new Requests.Accounts.ValidateAccountNumberChecksumRequest();

            request.action = "accounts_pending";
            request.account = account;

            return _client.SendRequestAsync<Responses.Accounts.ValidateAccountNumberChecksumResponse>(request);
        }
    }
}
