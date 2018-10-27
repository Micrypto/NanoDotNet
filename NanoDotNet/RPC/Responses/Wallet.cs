using System.Collections.Generic;
using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Responses.Wallet
{
    public class WalletAccountsBalancesResponse : Response
    {
        public Dictionary<string, Accounts.AccountBalanceResponse> balances;
    }

    public class WalletAddKeyResponse : Response
    {
        public string account;
    }

    public class WalletChangePasswordResponse : Response
    {
        public string changed;
    }

    public class WalletChangeSeedResponse : Response
    {
        public string success;
    }

    public class WalletContainsResponse : Response
    {
        public string exists;
    }

    public class WalletCreateResponse : Response
    {
        public string wallet;
    }

    public class WalletDestroyResponse : Response
    {
    }

    public class WalletExportResponse : Response
    {
        public string json; // TODO: create Wallet class.
    }

    public class WalletFrontiersResponse : Response
    {
        public Dictionary<string, string> frontiers;
    }

    public class WalletLockedCheckResponse : Response
    {
        public string locked;
    }

    public class WalletPasswordEnterResponse : Response
    {
        public string valid;
    }

    public class WalletPendingResponse : Response
    {
        public Dictionary<string, string[]> blocks;
    }

    public class WalletRepresentativeResponse : Response
    {
        public string representative;
    }

    public class WalletRepresentativeSetResponse : Response
    {
        public string set;
    }

    public class WalletRepublishResponse : Response
    {
        public string[] blocks;
    }

    public class WalletTotalBalanceResponse : Response
    {
        public BigInteger balance;
        public BigInteger pending;
    }

    public class WalletValidPasswordResponse : Response
    {
        public string valid;
    }

    public class WalletWorkGetResponse : Response
    {
        public Dictionary<string, string> works;
    }
}
