using System.Collections.Generic;
using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Responses.Frontiers
{
    public class FrontiersResponse : Response
    {
        public Dictionary<string, string> frontiers;
    }

    public class FrontiersCountResponse : Response
    {
        public BigInteger count;
    }

}
