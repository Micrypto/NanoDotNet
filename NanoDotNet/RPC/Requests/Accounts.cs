using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Requests.Accounts
{
    public class AccountBalanceRequest : Request
    {
        public string account;
    }

    public class AccountBlockCountRequest : Request
    {
        public string account;
    }

    public class AccountCreateRequest : Request
    {
        public string wallet;
        public bool work;
    }

    public class AccountGetRequest : Request
    {
        public string key;
    }

    public class AccountHistoryRequest : Request
    {
        public string account;
        public BigInteger count;
    }

    public class AccountInfoRequest : Request
    {
        public string account;
        public bool representative;
        public bool weight;
        public bool pending;
    }

    public class AccountListRequest : Request
    {
        public string wallet;
    }

    public class AccountMoveRequest : Request
    {
        public string wallet;
        public string source;
        public string[] accounts;
    }

    public class AccountPublicKeyRequest : Request
    {
        public string account;
    }

    public class AccountRemoveRequest : Request
    {
        public string wallet;
        public string account;
    }

    public class AccountRepresentativeRequest : Request
    {
        public string account;
    }

    public class AccountRepresentativeSetRequest : Request
    {
        public string wallet;
        public string account;
        public string representative;
    }

    public class AccountWeightRequest : Request
    {
        public string account;
    }

    public class AccountsBalancesRequest : Request
    {
        public string[] accounts;
    }

    public class AccountsCreateRequest : Request
    {
        public string wallet;
        public BigInteger count;
        public bool work;
    }

    public class AccountsFrontiersRequest : Request
    {
        public string[] accounts;
    }

    public class AccountsPendingRequest : Request
    {
        public string[] accounts;
        public BigInteger count;
    }

    public class ValidateAccountNumberChecksumRequest : Request
    {
        public string account;
    }
}
