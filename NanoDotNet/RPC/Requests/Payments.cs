using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Requests.Payments
{
    public class PaymentBeginRequest : Request
    {
        public string wallet;
    }

    public class PaymentEndRequest : Request
    {
        public string account;
        public string wallet;
    }

    public class PaymentInitRequest : Request
    {
        public string wallet;
    }

    public class PaymentWaitRequest : Request
    {
        public string account;
        public BigInteger amount;
        public int timeout;
    }

}
