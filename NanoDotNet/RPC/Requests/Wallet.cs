using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Requests.Wallet
{
    public class WalletAccountsBalancesRequest : Request
    {
        public string wallet;
        public BigInteger threshold;
    }

    public class WalletAddKeyRequest : Request
    {
        public string wallet;
        public string key;
        public bool work;
    }

    public class WalletChangePasswordRequest : Request
    {
        public string wallet;
        public string password;
    }

    public class WalletChangeSeedRequest : Request
    {
        public string wallet;
        public string seed;
    }

    public class WalletContainsRequest : Request
    {
        public string wallet;
        public string account;
    }

    public class WalletCreateRequest : Request
    {
    }

    public class WalletDestroyRequest : Request
    {
        public string wallet;
    }

    public class WalletExportRequest : Request
    {
        public string wallet;
    }

    public class WalletFrontiersRequest : Request
    {
        public string wallet;
    }

    public class WalletLockedCheckRequest : Request
    {
        public string wallet;
    }

    public class WalletPasswordEnterRequest : Request
    {
        public string wallet;
        public string password;
    }

    public class WalletPendingRequest : Request
    {
        public string wallet;
        public BigInteger count;
        public BigInteger threshold;
        public bool source;
    }

    public class WalletRepresentativeRequest : Request
    {
        public string wallet;
    }

    public class WalletRepresentativeSetRequest : Request
    {
        public string wallet;
        public string representative;
    }

    public class WalletRepublishRequest : Request
    {
        public string wallet;
        public BigInteger count;
    }

    public class WalletTotalBalanceRequest : Request
    {
        public string wallet;
    }

    public class WalletValidPasswordRequest : Request
    {
        public string wallet;
    }

    public class WalletWorkGetRequest : Request
    {
        public string wallet;
    }

}
