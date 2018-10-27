using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Requests.Conversion
{
    public class MRaiFromRawRequest : Request
    {
        public BigInteger amount;
    }

    public class MRaiToRawRequest : Request
    {
        public BigInteger amount;
    }

    public class KRaiFromRawRequest : Request
    {
        public BigInteger amount;
    }

    public class KRaiToRawRequest : Request
    {
        public BigInteger amount;
    }

    public class RaiFromRawRequest : Request
    {
        public BigInteger amount;
    }

    public class RaiToRawRequest : Request
    {
        public BigInteger amount;
    }
}
