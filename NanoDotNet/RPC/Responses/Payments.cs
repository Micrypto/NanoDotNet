namespace Micrypto.NanoDotNet.RPC.Responses.Payments
{
    public class PaymentBeginResponse : Response
    {
        public string account;
    }

    public class PaymentEndResponse : Response
    {
        public string success;
    }

    public class PaymentInitResponse : Response
    {
        public string status;
    }

    public class PaymentWaitResponse : Response
    {
        public string success;
    }

}
