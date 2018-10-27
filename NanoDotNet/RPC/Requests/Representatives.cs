namespace Micrypto.NanoDotNet.RPC.Requests.Representatives
{
    public class RepresentativesRequest : Request
    {
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

}
