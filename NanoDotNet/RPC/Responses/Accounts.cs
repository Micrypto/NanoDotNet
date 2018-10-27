using Newtonsoft.Json;
using System.Collections.Generic;
using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Responses.Accounts
{
    public class AccountBalanceResponse : Response
    {
        public BigInteger balance;
        public BigInteger pending;
    }

    public class AccountBlockCountResponse : Response
    {
        [JsonProperty("block_count")]
        public BigInteger blockCount;
    }

    public class AccountCreateResponse : Response
    {
        public string account;
    }

    public class AccountGetResponse : Response
    {
        public string account;
    }

    public class AccountHistoryResponse : Response
    {
        public DTOs.History[] history;
    }

    public class AccountInfoResponse : Response
    {
        public string frontier;
        [JsonProperty("open_block")]
        public string openBlock;
        [JsonProperty("representative_block")]
        public string representativeBlock;
        public BigInteger balance;
        [JsonProperty("modified_timestamp")]
        public BigInteger modifiedTimestamp;
        [JsonProperty("block_count")]
        public BigInteger blockCount;
        public string representative;
        public BigInteger weight;
        public BigInteger pending;
    }

    public class AccountListResponse : Response
    {
        public string[] accounts;
    }

    public class AccountMoveResponse : Response
    {
        public string moved;
    }

    public class AccountPublicKeyResponse : Response
    {
        public string key;
    }

    public class AccountRemoveResponse : Response
    {
        public string removed;
    }

    public class AccountRepresentativeResponse : Response
    {
        public string representative;
    }

    public class AccountRepresentativeSetResponse : Response
    {
        public string block;
    }

    public class AccountWeightResponse : Response
    {
        public BigInteger weight;
    }

    public class AccountsBalancesResponse : Response
    {
        public Dictionary<string, AccountBalanceResponse> balances;
    }

    public class AccountsCreateResponse : Response
    {
        public string[] accounts;
    }

    public class AccountsFrontiersResponse : Response
    {
        public Dictionary<string, string> frontiers;
    }

    public class AccountsPendingResponse : Response
    {
        public Dictionary<string, string[]> blocks;
    }

    public class ValidateAccountNumberChecksumResponse : Response
    {
        public string[] blocks;
    }

}
