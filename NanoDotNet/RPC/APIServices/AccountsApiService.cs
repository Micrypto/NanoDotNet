using Micrypto.NanoDotNet.RPC.Procs.Accounts;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class AccountsApiService
    {
        private Client.IClient _client;

        private AccountsApiService()
        {
        }

        public AccountsApiService(Client.IClient client)
        {
            _client = client;
        }

        public AccountBalance AccountBalance
        {
            get
            {
                return new AccountBalance(_client);
            }
        }

        public AccountBlockCount AccountBlockCount
        {
            get
            {
                return new AccountBlockCount(_client);
            }
        }

        public AccountCreate AccountCreate
        {
            get
            {
                return new AccountCreate(_client);
            }
        }

        public AccountGet AccountGet
        {
            get
            {
                return new AccountGet(_client);
            }
        }

        public AccountHistory AccountHistory
        {
            get
            {
                return new AccountHistory(_client);
            }
        }

        public AccountInfo AccountInfo
        {
            get
            {
                return new AccountInfo(_client);
            }
        }

        public AccountList AccountList
        {
            get
            {
                return new AccountList(_client);
            }
        }

        public AccountMove AccountMove
        {
            get
            {
                return new AccountMove(_client);
            }
        }

        public AccountPublicKey AccountPublicKey
        {
            get
            {
                return new AccountPublicKey(_client);
            }
        }

        public AccountRemove AccountRemove
        {
            get
            {
                return new AccountRemove(_client);
            }
        }

        public AccountRepresentative AccountRepresentative
        {
            get
            {
                return new AccountRepresentative(_client);
            }
        }

        public AccountRepresentativeSet AccountRepresentativeSet
        {
            get
            {
                return new AccountRepresentativeSet(_client);
            }
        }

        public AccountWeight AccountWeight
        {
            get
            {
                return new AccountWeight(_client);
            }
        }

        public AccountsBalances AccountsBalances
        {
            get
            {
                return new AccountsBalances(_client);
            }
        }

        public AccountsCreate AccountsCreate
        {
            get
            {
                return new AccountsCreate(_client);
            }
        }

        public AccountsFrontiers AccountsFrontiers
        {
            get
            {
                return new AccountsFrontiers(_client);
            }
        }

        public AccountsPending AccountsPending
        {
            get
            {
                return new AccountsPending(_client);
            }
        }

        public ValidateAccountNumberChecksum ValidateAccountNumberChecksum
        {
            get
            {
                return new ValidateAccountNumberChecksum(_client);
            }
        }
    }
}
