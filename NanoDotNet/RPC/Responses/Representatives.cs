using System.Collections.Generic;

namespace Micrypto.NanoDotNet.RPC.Responses.Representatives
{
    public class RepresentativesResponse : Response
    {
        public Dictionary<string, string> representatives;
    }

    public class WalletRepresentativeResponse : Response
    {
        public string representative;
    }

    public class WalletRepresentativeSetResponse : Response
    {
        public string set;
    }
}
