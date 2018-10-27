using System.Collections.Generic;
using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Responses.Delegators
{
    public class DelegatorsResponse : Response
    {
        public Dictionary<string, BigInteger> delegators;
    }

    public class DelegatorsCountResponse : Response
    {
        public BigInteger count;
    }

}
