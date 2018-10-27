using Micrypto.NanoDotNet.RPC.Procs.Wallet;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class WalletApiService
    {
        private Client.IClient _client;

        private WalletApiService()
        {
        }

        public WalletApiService(Client.IClient client)
        {
            _client = client;
        }

        public WalletAccountsBalances WalletAccountsBalances
        {
            get
            {
                return new WalletAccountsBalances(_client);
            }
        }

        public WalletAddKey WalletAddKey
        {
            get
            {
                return new WalletAddKey(_client);
            }
        }

        public WalletChangePassword WalletChangePassword
        {
            get
            {
                return new WalletChangePassword(_client);
            }
        }

        public WalletChangeSeed WalletChangeSeed
        {
            get
            {
                return new WalletChangeSeed(_client);
            }
        }

        public WalletContains WalletContains
        {
            get
            {
                return new WalletContains(_client);
            }
        }

        public WalletCreate WalletCreate
        {
            get
            {
                return new WalletCreate(_client);
            }
        }

        public WalletDestroy WalletDestroy
        {
            get
            {
                return new WalletDestroy(_client);
            }
        }

        public WalletExport WalletExport
        {
            get
            {
                return new WalletExport(_client);
            }
        }

        public WalletFrontiers WalletFrontiers
        {
            get
            {
                return new WalletFrontiers(_client);
            }
        }

        public WalletLockedCheck WalletLockedCheck
        {
            get
            {
                return new WalletLockedCheck(_client);
            }
        }

        public WalletPasswordEnter WalletPasswordEnter
        {
            get
            {
                return new WalletPasswordEnter(_client);
            }
        }

        public WalletPending WalletPending
        {
            get
            {
                return new WalletPending(_client);
            }
        }

        public WalletRepresentative WalletRepresentative
        {
            get
            {
                return new WalletRepresentative(_client);
            }
        }

        public WalletRepresentativeSet WalletRepresentativeSet
        {
            get
            {
                return new WalletRepresentativeSet(_client);
            }
        }

        public WalletRepublish WalletRepublish
        {
            get
            {
                return new WalletRepublish(_client);
            }
        }

        public WalletTotalBalance WalletTotalBalance
        {
            get
            {
                return new WalletTotalBalance(_client);
            }
        }

        public WalletValidPassword WalletValidPassword
        {
            get
            {
                return new WalletValidPassword(_client);
            }
        }

        public WalletWorkGet WalletWorkGet
        {
            get
            {
                return new WalletWorkGet(_client);
            }
        }
    }
}