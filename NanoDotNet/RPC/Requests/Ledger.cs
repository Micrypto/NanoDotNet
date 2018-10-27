using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Requests.Ledger
{
    public class HistoryRequest : Request
    {
        public string hash;
        public BigInteger count;
    }

    public class LedgerRequest : Request
    {
        public string account;
        public BigInteger count;
        public bool representative;
        public bool weight;
        public bool pending;
    }

    public class SuccessorsRequest : Request
    {
        public string block;
        public BigInteger count;
    }

}
